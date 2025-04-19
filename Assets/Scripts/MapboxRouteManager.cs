using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Linq;
using Mapbox.Utils;  // Make sure you have Mapbox SDK installed

public class MapboxRouteManager : MonoBehaviour
{
    [Header("Set Your Mapbox Token Here")]
    public string mapboxAccessToken;

    [Header("Reference to Display Script")]
    public RouteDisplay routeDisplay;

    public void RequestRoute(List<Vector2d> waypoints)
    {
        StartCoroutine(GetRouteCoroutine(waypoints));
    }

    string FormatWaypoints(List<Vector2d> locations)
    {
        return string.Join(";", locations.Select(loc => $"{loc.x.ToString(System.Globalization.CultureInfo.InvariantCulture)},{loc.y.ToString(System.Globalization.CultureInfo.InvariantCulture)}"));
    }

    IEnumerator GetRouteCoroutine(List<Vector2d> locations)
    {
        string baseUrl = "https://api.mapbox.com/directions/v5/mapbox/walking/";
        string coordinates = FormatWaypoints(locations);
        string url = $"{baseUrl}{coordinates}?geometries=geojson&access_token={mapboxAccessToken}";

        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError($"Mapbox API error: {www.error}");
        }
        else
        {
            string json = www.downloadHandler.text;
            RouteResponse response = JsonUtility.FromJson<RouteResponse>(json);

            if (response.routes != null && response.routes.Length > 0)
            {
                RouteGeometry parsed = response.routes[0].geometry;
                routeDisplay.DisplayRoute(parsed.coordinates);
            }
            else
            {
                Debug.LogWarning("No routes found in the API response. Check if all locations are reachable.");
            }
        }
    }


    // Classes to deserialize JSON
    [System.Serializable]
    public class RouteResponse
    {
        public Route[] routes;
    }

    [System.Serializable]
    public class Route
    {
        public RouteGeometry geometry;
    }

    [System.Serializable]
    public class RouteGeometry
    {
        public string type;
        public List<List<double>> coordinates;
    }
}
