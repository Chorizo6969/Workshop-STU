using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMove : MonoBehaviour
{
    public int speed;
    [SerializeField] private int spread;
    private float fireSpread;
    // Start is called before the first frame update
    void Start()
    {
         
        fireSpread = Random.Range(-spread, spread);
        
        fireSpread /= 100;
        Debug.Log(fireSpread);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(1, fireSpread, 0) * speed * Time.deltaTime;
        if (transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
