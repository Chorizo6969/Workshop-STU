using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class francistir : MonoBehaviour
{
    public GameObject projectileFrancis;
    private float timer;
    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 0.25) 
        {
            GameObject francisMissile = Instantiate(projectileFrancis);
            francisMissile.transform.position = spawnLocation.transform.position;
            timer = 0;
        }
    }
}
