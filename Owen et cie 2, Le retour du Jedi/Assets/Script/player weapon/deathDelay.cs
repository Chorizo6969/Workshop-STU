using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathDelay : MonoBehaviour
{
    public float deathCooldown;
    private float time;
    

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > deathCooldown)
        {
            Destroy(gameObject);
        }
    }
}
