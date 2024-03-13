using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Ennemy : MonoBehaviour //Script qui gère le comportement de l'ennemi 1
{
    [SerializeField] private GameObject missile;
    [SerializeField] private float Synchro = 1;
    [SerializeField] private int cooldown = 3;

    [SerializeField] protected bool isfirstCouroutineStart = false;


    public int ennemy_speed = 3;

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * ennemy_speed * Time.deltaTime); //On applique une direction vers la gauche selon la variable speed (Vector3.up car l'objet à fait une rotation de 90 degré)
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < 10 && !isfirstCouroutineStart) //Pour éviter que l'ennemi tire depuis l'autre bout du monde
        {
            StartCoroutine(Attaque());
        }
    }
    IEnumerator Attaque() //Coroutine qui instancie un prefab du missile
    {
        isfirstCouroutineStart = true;
        yield return new WaitForSeconds(Synchro);
        GameObject new_missile  = Instantiate(missile);
        new_missile.transform.position = transform.position;
        yield return new WaitForSeconds(cooldown);
        StartCoroutine(Attaque());
    }

    public void OnDeath()
    {
        FindAnyObjectByType<killCount>().gameObject.GetComponent<killCount>().ennemiKillCount++;
    }
}