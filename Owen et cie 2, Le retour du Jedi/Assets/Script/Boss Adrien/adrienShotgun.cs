using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class adrienShotgun : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject spawnPoint;

    public void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        GameObject _Instantiation = Instantiate(bulletObject);
        _Instantiation.transform.position = spawnPoint.transform.position;

        yield return new WaitForSeconds(2.5f); StartCoroutine(Shoot());
    }
}
