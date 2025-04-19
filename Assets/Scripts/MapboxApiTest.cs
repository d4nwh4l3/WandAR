using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using Mapbox.Utils;

public class MapboxApiTest : MonoBehaviour
{
    [TextArea(2, 10)]
    public string mapboxAccessToken;

    void Start()
    {
        // A known valid route near Pitt campus
        List<Vector2d> testPoints = new List<Vector2d>()
        {
            new Vector2d(40.443968626758696, -79.95365809631727),
            new Vector2d(40.444668, -79.952000),
        };

        StartCoroutine(TestRouteRequest(testPoints));
    }

    IEnumerator TestRouteRequest(List<Vector2d> locations)
    {
        string baseUrl = "https://api.mapbox.com/directions/v5/mapbox/walking/";
        string coords = FormatWaypoints(locations);
        string url = $"{baseUrl}{coords}?geometries=geojson&access_token={mapboxAccessToken}";

        Debug.Log($"Testing Mapbox request: {url}");

        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError($"[API TEST] Mapbox request failed: {www.error}");
        }
        else
        {
            string json = www.downloadHandler.text;
            Debug.Log($"[API TEST] Response:\n{json}");

            RouteResponse response = JsonUtility.FromJson<RouteResponse>(json);

            if (response.routes != null && response.routes.Length > 0)
            {
                int coordCount = response.routes[0].geometry.coordinates.Count;
                Debug.Log($"[API TEST] Route received with {coordCount} coordinates.");
            }
            else
            {
                Debug.LogWarning("[API TEST] No routes found in response.");
            }
        }
    }

    string FormatWaypoints(List<Vector2d> points)
    {
        List<string> coords = new List<string>();
        foreach (Vector2d point in points)
        {
            coords.Add($"{point.y.ToString("F6")},{point.x.ToString("F6")}"); // lon,lat
        }
        return string.Join(";", coords);
    }

    [System.Serializable]
    public class RouteResponse
    {
        public Route[] routes;
    }

    [System.Serializable]
    public class Route
    {
        public Geometry geometry;
    }

    [System.Serializable]
    public class Geometry
    {
        public List<List<double>> coordinates;
    }
}
