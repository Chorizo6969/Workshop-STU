using UnityEngine;

public class ChooseUlti : MonoBehaviour
{
    public GameObject player_id;
    public int id_ulti;
    public GameObject Sprite_ulti1;
    public GameObject Sprite_ulti2;
    public void Ulti()
    {
        player_id.GetComponent<Control>().UltId = id_ulti;
    }

    public void showSprite()
    {
        if (id_ulti == 0)
        {
            Sprite_ulti1.SetActive(true);
            Sprite_ulti2.SetActive(false);
        }
        else if (id_ulti == 1)
        {
            Sprite_ulti1.SetActive(false);
            Sprite_ulti2.SetActive(true);
        }
    }
}
