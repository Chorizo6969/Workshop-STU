using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inflictdamage : MonoBehaviour
{
    public string targetTag;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ennemiShield" && gameObject.tag == "playerProjectile")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == targetTag)
        {
            collision.gameObject.GetComponent<entityLife>().life -= damage;
            if (gameObject.name != "laser(Clone)" && gameObject.layer != 6)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Player" && collision.gameObject.name == "Player" && gameObject.tag != "playerProjectile")
        {
            //FindAnyObjectByType<Life>().take_damages(damage);
        }
    }
}