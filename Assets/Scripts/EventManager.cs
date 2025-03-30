using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public int maxDistance = 70;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateEvent(int eventID)
    {
        Debug.Log("Activating event with ID: " + eventID);

        if (eventID == 1) // William Pitt Union
        {
            SceneManager.LoadScene("William Pitt Union");
        }
        else if (eventID == 2) // Cathedral of Learning
        {
            SceneManager.LoadScene("Cathedral of Learning");
        }
        else if (eventID == 3) // Benedum Hall
        {
            SceneManager.LoadScene("Benedum Hall");
        }
        else if (eventID == 4) // Frick Fine Arts
        {
            SceneManager.LoadScene("Frick Fine Arts");
        }
        else if (eventID == 5) // Peterson Events Center
        {
            SceneManager.LoadScene("Peterson Events Center");
        }
        else if (eventID == 6) // Heinz Chapel
        {
            SceneManager.LoadScene("Heinz Chapel");
        }
        else if (eventID == 7) // Hillman Library
        {
            SceneManager.LoadScene("Hillman Library");
        }
        else if (eventID == 8) // Information Sciences
        {
            SceneManager.LoadScene("Information Sciences");
        }
    }
}
