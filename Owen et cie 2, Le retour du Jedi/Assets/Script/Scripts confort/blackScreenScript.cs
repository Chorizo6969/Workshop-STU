using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackScreenScript : MonoBehaviour
{
    public GameObject baclScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(baclScreen);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * 2);
    }
}
