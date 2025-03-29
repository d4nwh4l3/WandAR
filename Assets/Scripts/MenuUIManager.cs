using UnityEngine;
using UnityEngine.UI; 

public class MenuUIManager : MonoBehaviour 
{
    [SerializeField] private GameObject eventPanelUserInRange;
    [SerializeField] private GameObject eventPanelUserNotInRange;

    void Start(){

    }

    void Update(){

    }
    public void DisplayStartEventPanel(){
        eventPanelUserInRange.SetActive(true);
    }
    public void DisplayUserNotInRangePanel(){
        eventPanelUserNotInRange.SetActive(true);

    }
}
