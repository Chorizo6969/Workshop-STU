using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setactiveEndTrue : MonoBehaviour
{
    public GameObject endObject;

    private void Start()
    {
        endObject = FindAnyObjectByType<Ending>().gameObject;
    }

    void Update()
    {
        if (GetComponent<entityLife>().life <= 0)
        {
            endObject.SetActive(true);
        }
    }
}