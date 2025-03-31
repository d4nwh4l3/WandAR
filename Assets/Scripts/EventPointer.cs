using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mapbox Library
using Mapbox.Examples;
using Mapbox.Utils;
public class EventPointer : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float amplitude = 2.0f;
    [SerializeField] private float frequency = 0.50f;

    LocationStatus playerLocation;
    public Vector2d eventPose;
    public int eventID;
    MenuUIManager MenuUIManager;
    EventManager eventManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MenuUIManager = GameObject.Find("Canvas").GetComponent<MenuUIManager>();
        eventManager = GameObject.Find("-EventManager").GetComponent<EventManager>();
    }

    // Update is called once per frame
    void Update()
    {
        FloatAndRotatePointer();
    }


    void FloatAndRotatePointer()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude) + 15, transform.position.z);
    }
    private void OnMouseDown()
    {
        playerLocation = GameObject.Find("Canvas").GetComponent<LocationStatus>();
        var currentPlayerLocation = new GeoCoordinatePortable.GeoCoordinate(playerLocation.GetLocationLat(), playerLocation.GetLocationLon());
        var eventLocation = new GeoCoordinatePortable.GeoCoordinate(eventPose[0], eventPose[1]);
        var distance = currentPlayerLocation.GetDistanceTo(eventLocation);

        Debug.Log("Distance is " + distance);
        if (distance < eventManager.maxDistance)
        {
            MenuUIManager.DisplayStartEventPanel(eventID);
        }
        else
        {
            MenuUIManager.DisplayUserNotInRangePanel();
        }

    }
}