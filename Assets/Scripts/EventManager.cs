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
    public GameObject event7;
    public GameObject event8;
    public GameObject event9;
    public GameObject event10;
    public GameObject event11;
    public GameObject event12;
    public GameObject event13;
    public GameObject event14;
    public GameObject event15;
    public GameObject event16;
    public GameObject event17;
    public GameObject event18;
    public GameObject event19;

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
            event6.SetActive(true);
        }
        if (eventID == 7) //Allen Hall
        {
            event7.SetActive(true);
        }
        if (eventID == 8) //Alumni Hall
        {
            event8.SetActive(true);
        }
        if (eventID == 9) //Carnegie Library
        {
            event9.SetActive(true);
        }
        if (eventID == 10) //Carnegie Museum of Art
        {
            event10.SetActive(true);
        }
        if (eventID == 11) //Carnegie Museum of Natural History
        {
            event11.SetActive(true);
        }
        if (eventID == 12) //Chevron Science Center
        {
            event12.SetActive(true);
        }
        if (eventID == 13) //Phipps
        {
            event13.SetActive(true);
        }
        if (eventID == 14) //Soldiers and Sailors
        {
            event14.SetActive(true);
        }
        if (eventID == 15) //St Pauls Cathedral
        {
            event15.SetActive(true);
        }
        if (eventID == 16) //Log Cabin
        {
            event16.SetActive(true);
        }
        if (eventID == 17) //UPMC
        {
            event17.SetActive(true);
        }
        if (eventID == 18) //Victoria
        {
            event18.SetActive(true);
        }
        if (eventID == 19) //Posvar
        {
            event19.SetActive(true);
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
        event7.SetActive(false);
        event8.SetActive(false);
        event9.SetActive(false);
        event10.SetActive(false);
        event11.SetActive(false);
        event12.SetActive(false);
        event13.SetActive(false);
        event14.SetActive(false);
        event15.SetActive(false);
        event16.SetActive(false);
        event17.SetActive(false);
        event18.SetActive(false);
        event19.SetActive(false);
    }
}
