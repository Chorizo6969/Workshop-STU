using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdrienMissile : MonoBehaviour
{
    public int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
