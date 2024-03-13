using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincible : MonoBehaviour
{
    private void Start()
    {
        GetComponent<entityLife>().life = 2147483647;
    }
}