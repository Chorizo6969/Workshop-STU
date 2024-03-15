using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyMoveDown : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3);
    }
}
