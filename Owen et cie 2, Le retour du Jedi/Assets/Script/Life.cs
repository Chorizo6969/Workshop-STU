using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour //Script qui gère la vie du joueur, les degats comme les soins
{
    public int Max_healthlife = 100;
    public int Currenthealth;
    public Slider slider; // Fait le lien entre mes valeurs et le slider

    public void Start()
    {
        Currenthealth = Max_healthlife;
        //slider.value = Currenthealth;
        slider.maxValue = Max_healthlife;
    }
    public void take_damages(int damages) //Fonction qui soustraie x pv a la vie du joueur
    {
        Currenthealth -= damages;
        slider.value = Currenthealth;
    }
    public void Heal(int soin) //Fonction qui ajoute x pv a la vie du joueur
    {
        if (Currenthealth + soin < Max_healthlife)
        {
            Currenthealth += soin;
            slider.value = Currenthealth;
        }
    }
}
