using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class francisProjectile : MonoBehaviour
{
    public Vector3 direction;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 0);
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
}
