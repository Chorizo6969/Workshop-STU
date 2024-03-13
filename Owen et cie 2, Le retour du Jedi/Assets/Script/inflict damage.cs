using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inflictdamage : MonoBehaviour
{
    public string targetTag;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "shield")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == targetTag)
        {
            collision.gameObject.GetComponent<entityLife>().life -= damage;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player" && collision.gameObject.name == "Player")
        {
            FindAnyObjectByType<Life>().take_damages(damage);
        }
    }
}