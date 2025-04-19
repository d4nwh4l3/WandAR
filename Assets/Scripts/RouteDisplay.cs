using System.Collections.Generic;
using UnityEngine;

public class RouteDisplay : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float lineHeight = 0.1f;

    public void DisplayRoute(List<List<double>> coordinates)
    {
        Vector3[] points = new Vector3[coordinates.Count];

        for (int i = 0; i < coordinates.Count; i++)
        {
            float lon = (float)coordinates[i][0];
            float lat = (float)coordinates[i][1];

            // Convert lon/lat to Unity positions based on your map setup.
            points[i] = new Vector3(lon, lineHeight, lat);
        }

        lineRenderer.positionCount = points.Length;
        lineRenderer.SetPositions(points);
        lineRenderer.enabled = true; // make sure it's visible
    }

    public void HideRoute()
    {
        lineRenderer.enabled = false;
    }
}
