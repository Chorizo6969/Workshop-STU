using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrancisMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(-1, -2, 0) * Time.deltaTime * speed;
    }
}
