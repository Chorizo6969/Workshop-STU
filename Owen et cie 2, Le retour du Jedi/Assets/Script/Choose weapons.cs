using UnityEngine;

public class Chooseweapons : MonoBehaviour
{
    public GameObject player_id;
    public int id;

    public void Weapoons()
    {
        player_id.GetComponent<Control>().secondWeaponId = id;
    }
 
}
