using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour //Script qui gère la vie du joueur, les degats comme les soins
{
    public int Max_healthlife = 100;
    public int Currenthealth;
    public Slider slider; // Fait le lien entre mes valeurs et le slider
    public float DOTweenSpeed;
    public Ease functionName;
    public Slider slider_latence;

    public void Start()
    {
        Currenthealth = Max_healthlife;
        slider.maxValue = Max_healthlife;
    }
    IEnumerator Damages_Delay()
    {
        yield return new WaitForSeconds(0.7f);
        slider_latence.DOValue(Currenthealth, DOTweenSpeed).SetEase(functionName);
    }

    public void take_damages(int damages) //Fonction qui soustraie x pv a la vie du joueur
    {
        Currenthealth -= damages;
        slider.DOValue(Currenthealth, DOTweenSpeed).SetEase(functionName);
        StartCoroutine(Damages_Delay());
    }
    public void Heal(int soin) //Fonction qui ajoute x pv a la vie du joueur
    {
        if (Currenthealth + soin <= Max_healthlife)
        { 
            Currenthealth += soin;
            slider.DOValue(Currenthealth, 0.2f).SetEase(Ease.OutQuint); //Twin de la vie du joueur qui  permet pendant une transition de 0.2s d'augmenter la vie
            //slider_latence.value = Currenthealth;
        }
        else if(Currenthealth + soin > Max_healthlife)
        {
            Currenthealth = Max_healthlife;
            slider.DOValue(Currenthealth, 0.2f).SetEase(Ease.OutQuint);
            slider_latence.value = Currenthealth;
        }
    }
}
