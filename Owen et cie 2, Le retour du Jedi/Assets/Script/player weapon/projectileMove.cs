using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMove : MonoBehaviour
{
    public int speed;
    public int spread;
    private float fireSpread;
    // Start is called before the first frame update
    void Start()
    {
         
        fireSpread = Random.Range(-spread, spread);
        
        fireSpread /= 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(1, fireSpread, 0);
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
        if (transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
