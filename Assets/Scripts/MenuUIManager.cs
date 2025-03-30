using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private GameObject eventPanelUserInRange;
    [SerializeField] private GameObject eventPanelUserNotInRange;
    
    private bool isUIPanelActive;
    private int tempEvent; 
    [SerializeField] private EventManager eventManager;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DisplayStartEventPanel(int eventID)
    {
        if (!isUIPanelActive) // ✅ Simplified condition
        {
            tempEvent = eventID;
            eventPanelUserInRange.SetActive(true);
            isUIPanelActive = true;
        }
    }

    public void OnJoinButtonClick()
    {
    eventManager.ActivateEvent(tempEvent);
    }

    public void DisplayUserNotInRangePanel()
    {
        if (!isUIPanelActive)
        {
            eventPanelUserNotInRange.SetActive(true);
            isUIPanelActive = true;
        }
    }

    public void CloseButtonClick()
    {
        eventPanelUserInRange.SetActive(false);
        eventPanelUserNotInRange.SetActive(false);
        isUIPanelActive = false;
    }
}
