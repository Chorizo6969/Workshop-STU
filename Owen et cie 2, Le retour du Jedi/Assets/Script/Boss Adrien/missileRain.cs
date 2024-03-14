using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileRain : MonoBehaviour
{
    public GameObject preAttackObject;
    public GameObject preattackSpawnPoint;
    public GameObject missileProjectile;
    public int fireCount;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator AttackDelay(Vector3 _spawnPos)
    {
        GameObject _preAttackObject = Instantiate(preAttackObject);
        _preAttackObject.transform.position = _spawnPos;
        yield return new WaitForSeconds(1);
        Destroy(_preAttackObject);
    }

    IEnumerator Attack()
    {
        int countLimit = Random.Range(10, 20);
        StartCoroutine(AttackDelay(preattackSpawnPoint.transform.position));
        yield return new WaitForSeconds(7.5f);
        StartCoroutine(FireMissileRain(countLimit));
        
        yield return new WaitForSeconds(6);
        StartCoroutine(Attack());
    }

    IEnumerator FireMissileRain(int countLimit)
    {
        fireCount++;
        GameObject _adrienMissile = Instantiate(missileProjectile);
        _adrienMissile.SetActive(false);
        _adrienMissile.transform.position = new Vector3(Random.Range(-8.36f, 3.27f), 6, 0);
        StartCoroutine(AttackDelay(_adrienMissile.transform.position));
        _adrienMissile.transform.position += new Vector3(0, 5, 0);
        _adrienMissile.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        if (countLimit >= fireCount)
        {
            StartCoroutine(FireMissileRain(countLimit));
        }
        else if (countLimit < fireCount)
        {
            fireCount = 0;
        }
    }
}
