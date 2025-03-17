using UnityEngine;

<<<<<<< Updated upstream
public class NewEmptyCSharpScript
{
    
=======
public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private GameObject eventPanelUserInRange;
    [SerializeField] private GameObject eventPanelUserNotInRange;
    bool isUIPanelActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayStartEventPanel()
    {
        if (isUIPanelActive == false)
        {
            eventPanelUserInRange.SetActive(true);
            isUIPanelActive = true;
        }
    }
    public void DisplayUserNotInRangePanel()
    {
        if (isUIPanelActive == false)
        {
            eventPanelUserNotInRange.SetActive(true);
        }
    }

    public void CloseButtonClick()
    {
        eventPanelUserInRange.SetActive(false);
        eventPanelUserNotInRange.SetActive(false);
        isUIPanelActive = false;
    }
>>>>>>> Stashed changes
}
