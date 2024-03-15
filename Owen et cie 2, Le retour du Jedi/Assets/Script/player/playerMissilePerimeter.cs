using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMissilePerimeter : MonoBehaviour
{
    public List<GameObject> ennemy;

    private void Start()
    {
        //ennemy = new List<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ennemyThings")
        {
            ennemy.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ennemy.Remove(collision.gameObject);
    }
}
