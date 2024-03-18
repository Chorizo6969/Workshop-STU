using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaPompeUlt : MonoBehaviour
{
    public GameObject projectile;
    public int bigSpread;

    private void OnEnable()
    {
        for (int i = 0; i < 50; i++)
        {
            FindAnyObjectByType<Control>().instantiateProjectil(projectile, bigSpread);
        }
    }
}
