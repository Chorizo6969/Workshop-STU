using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateEnd : MonoBehaviour
{
    public GameObject endObject;

    private void Start()
    {
        endObject = FindAnyObjectByType<Ending>().gameObject;
        endObject.transform.position = new Vector3(8, 0, 0);
    }
}
