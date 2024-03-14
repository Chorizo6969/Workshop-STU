using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniInterMove : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    private void Start()
    {
        direction.Normalize();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
