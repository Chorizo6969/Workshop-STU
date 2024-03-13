using UnityEngine;
using UnityEngine.EventSystems;

public class Eventsystemnavigation : MonoBehaviour
{
    public GameObject Level_1;
    //public GameObject Options;
    public GameObject Weapons;
    public void Change_Window()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(Level_1, new BaseEventData(eventSystem));
    }

    public void Change_Weapons()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(Weapons, new BaseEventData(eventSystem));
    }

    /*public void Change_Option()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(Options, new BaseEventData(eventSystem));
    }*/

}
