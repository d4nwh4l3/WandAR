namespace Mapbox.Examples
{
    using Mapbox.Unity.Location;
    using Mapbox.Utils;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class LocationStatus : MonoBehaviour
    {
        [SerializeField]
        private Text _statusText;

        private AbstractLocationProvider _locationProvider = null;
        Location currLoc;
        void Start()
        {
            if (LocationProviderFactory.Instance != null)
            {
                _locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
            }

            if (_locationProvider == null)
            {
                Debug.LogError("LocationProvider is null! Make sure LocationProviderFactory is properly initialized.");
            }
        }

        void Update()
        {
            if (_locationProvider == null)
            {
                Debug.LogError("LocationProvider is still null in Update. Skipping location update.");
                return;
            }

            currLoc = _locationProvider.CurrentLocation;

            if (_statusText == null)
            {
                Debug.LogError("StatusText UI element is not assigned!");
                return;
            }

           
            if (currLoc.IsLocationServiceInitializing)
            {
                _statusText.text = "Location services are initializing...";
            }
            else if (!currLoc.IsLocationServiceEnabled)
            {
                _statusText.text = "Location services not enabled.";
            }
            else if (currLoc.LatitudeLongitude.Equals(Vector2d.zero))
            {
                _statusText.text = "Waiting for location...";
            }
            else
            {
                _statusText.text = string.Format("Location: {0}", currLoc.LatitudeLongitude);
            }
        }
        public double GetLocationLat()
        {
            return currLoc.LatitudeLongitude.x;
        }

        public double GetLocationLon()
        {
            return currLoc.LatitudeLongitude.y;
        }

    }


}