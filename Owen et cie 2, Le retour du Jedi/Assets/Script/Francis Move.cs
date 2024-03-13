using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrancisMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, -2, 0) * Time.deltaTime * 3;
    }
}
