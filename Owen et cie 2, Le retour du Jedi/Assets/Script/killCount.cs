using UnityEngine;
using UnityEngine.UI;

public class killCount : MonoBehaviour
{
    public int ennemiKillCount;

    public GameObject border;
    public GameObject border_2;
    public GameObject Sprite_ulti1;
    public GameObject Sprite_ulti2;
    public Control ulti;

    [SerializeField] private Sprite sprite_0;
    [SerializeField] private Sprite sprite_1;
    [SerializeField] private Sprite sprite_2;
    [SerializeField] private Sprite sprite_3;
    [SerializeField] private Sprite sprite_4;

    public void Start()
    {
        if (ulti.UltId == 0)
        {
            Sprite_ulti1.SetActive(true);
            Sprite_ulti2.SetActive(false);
        }
        else
        {
            Sprite_ulti1.SetActive(false);
            Sprite_ulti2.SetActive(true);
        }
    }
    public void ChangeSoriteUlti()
    {
        if (ulti.UltId == 0)
        {
            switch (ennemiKillCount)
            {
                case 0:
                    border.GetComponent<Image>().sprite = sprite_0;
                    break;
                case 8:
                    border.GetComponent<Image>().sprite = sprite_1;
                    break;
                case 16:
                    border.GetComponent<Image>().sprite = sprite_2;
                    break;
                case 24:
                    border.GetComponent<Image>().sprite = sprite_3;
                    break;
                case 32:
                    border.GetComponent<Image>().sprite = sprite_4;
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (ennemiKillCount)
            {
                case 0:
                    border_2.GetComponent<Image>().sprite = sprite_0;
                    break;
                case 8:
                    border_2.GetComponent<Image>().sprite = sprite_1;
                    break;
                case 16:
                    border_2.GetComponent<Image>().sprite = sprite_2;
                    break;
                case 24:
                    border_2.GetComponent<Image>().sprite = sprite_3;
                    break;
                case 32:
                    border_2.GetComponent<Image>().sprite = sprite_4;
                    break;
                default:
                    break;
            }

        }
    }
}
