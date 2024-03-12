using UnityEngine;

public class Missile : MonoBehaviour //Script qui permet de donner des actions aux projectiles sortant des ennemmis.
{
    public int speed = 8;
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); //On applique une direction vers la gauche selon la variable speed (Vector3.up car l'objet à fait une rotation de 90 degré)
        if (transform.position.x < -15) //Si l'objet arrive en -15 ou moins, il est détruit
        {
            Destroy(gameObject);
        }
    }
}
