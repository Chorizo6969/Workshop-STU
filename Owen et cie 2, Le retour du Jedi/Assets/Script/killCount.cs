using UnityEngine;
using UnityEngine.UI;

public class killCount : MonoBehaviour
{
    public int ennemiKillCount;
    public int killForNextUlt;
    public GameObject border;

    [SerializeField] private Sprite sprite_0;
    [SerializeField] private Sprite sprite_1;
    [SerializeField] private Sprite sprite_2;
    [SerializeField] private Sprite sprite_3;
    [SerializeField] private Sprite sprite_4;


    public void ChangeSoriteUlti()
    {
        switch(ennemiKillCount)
            {
            case 0:
                border.GetComponent<Image>().sprite = sprite_0;
                break;
            case 2:
                border.GetComponent<Image>().sprite = sprite_1;
                break;
            case 4:
                border.GetComponent<Image>().sprite = sprite_2;
                break;
            case 6:
                border.GetComponent<Image>().sprite = sprite_3;
                break;
            case 8:
                border.GetComponent<Image>().sprite = sprite_4;
                break;
            default:
                break;
            }
        }
}
