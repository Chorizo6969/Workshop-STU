using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adrienBullet : MonoBehaviour
{
    public Vector3 direction;

    private void Start()
    {
        direction.Normalize();
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * 7.5f);
    }
}
