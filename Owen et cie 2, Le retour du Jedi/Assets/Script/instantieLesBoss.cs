using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantieLesBoss : MonoBehaviour
{
    public GameObject bossPrefab;

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<entityLife>().life <= 0)
        {
            Instantiate(bossPrefab);
            Destroy(gameObject);
        }
    }
}
