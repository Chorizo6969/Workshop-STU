using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMissilePerimeter : MonoBehaviour
{
    public List<GameObject> ennemy;

    private void Start()
    {
        ennemy = new List<GameObject>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION");
        if (collision.gameObject.layer == 6)
        {
            ennemy.Add(collision.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ennemy.Remove(collision.gameObject);
    }
}
