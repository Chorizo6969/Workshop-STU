using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inflictdamage : MonoBehaviour
{
    public string targetTag;
    public int damage;
    public string healthBarName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ennemiShield" && gameObject.tag == "playerProjectile")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == targetTag || (gameObject.tag == "playerProjectile" && collision.gameObject.tag == "boss"))
        {
            collision.gameObject.GetComponent<entityLife>().life -= damage;
            if (gameObject.name != "laser(Clone)" && gameObject.layer != 6)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Player" && collision.gameObject.name == "Player" && gameObject.tag != "playerProjectile")
        {
            GameObject.Find("Health").gameObject.GetComponentInChildren<Life>().take_damages(damage);
        }

        if (collision.gameObject.tag == "boss")
        {
            Debug.Log(gameObject.name);
            var health = GameObject.Find(collision.gameObject.GetComponent<inflictdamage>().healthBarName).gameObject;
            health.GetComponentInChildren<Life>().take_damages(damage);
        }
    }
}