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

<<<<<<< HEAD
    LocationStatus playerLocation;
    public Vector2d eventPose;
<<<<<<< Updated upstream
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
=======
    public int eventID;
    MenuUIManager MenuUIManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MenuUIManager = GameObject.Find("Canvas").GetComponent<MenuUIManager>();
>>>>>>> Stashed changes
=======

    LocationStatus playerLocation;
    public Vector2d eventPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

>>>>>>> 96fff842c9784b35253416107c7f3b976777337d
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
<<<<<<< HEAD
        var eventLocation = new GeoCoordinatePortable.GeoCoordinate(eventPose[0], eventPose[1]);
        var distance = currentPlayerLocation.GetDistanceTo(eventLocation);
<<<<<<< Updated upstream
            Debug.Log("Distance is " + distance);
       
=======
        Debug.Log("Distance is " + distance);
        if(distance < 70)
        {
            MenuUIManager.DisplayStartEventPanel();
        }else
        {
            MenuUIManager.DisplayUserNotInRangePanel();
        }

>>>>>>> Stashed changes
=======
        var eventLocation = new GeoCoordinatePortable.GeoCoordinate(eventPos[0], eventPos[1]);
        var distance = currentPlayerLocation.GetDistanceTo(eventLocation);
        Debug.Log("Distance is " + distance);

>>>>>>> 96fff842c9784b35253416107c7f3b976777337d
    }
}