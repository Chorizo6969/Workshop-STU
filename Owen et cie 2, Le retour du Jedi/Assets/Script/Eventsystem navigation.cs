using UnityEngine;
using UnityEngine.EventSystems;

public class Eventsystemnavigation : MonoBehaviour
{
    public GameObject Level_1;
    public GameObject Weapons;
    public GameObject WeaponsL2;
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

    public void Change_WeaponsL2()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(WeaponsL2, new BaseEventData(eventSystem));
    }
}
