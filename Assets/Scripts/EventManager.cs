using UnityEngine;

public class EventManager : MonoBehaviour
{
    public int maxDistance = 70;
    public GameObject event1;
    public GameObject event2;
    public GameObject event3;
    public GameObject event4;
    public GameObject event5;
    public GameObject event6;

    public void ActivateEvent(int eventID)
    {
        if(eventID == 1) //Cathedral of Learning
        {
            event1.SetActive(true);
        }
        if (eventID == 2) //WPU
        {
            event2.SetActive(true);
        }
        if (eventID == 3) //Hillman
        {
            event3.SetActive(true);
        }
        if (eventID == 4) //Benedum
        {
            event4.SetActive(true);
        }
        if (eventID == 5) //ISBuilding
        {
            event5.SetActive(true);
        }
        if (eventID == 6) //Pete
        {
            event5.SetActive(true);
        }
    }

    public void CloseAllEvents()
    {
        event1.SetActive(false);
        event2.SetActive(false);
        event3.SetActive(false);
        event4.SetActive(false);
        event5.SetActive(false);
        event6.SetActive(false);
    }
}
