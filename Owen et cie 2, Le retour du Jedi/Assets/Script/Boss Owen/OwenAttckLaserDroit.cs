using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwenAttckLaserDroit : MonoBehaviour
{
    public GameObject preAttack;
    public GameObject preAttackSpawnPoint;
    public GameObject attack;
    public GameObject attackSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(attackDelay());
    }

    IEnumerator attackDelay()
    {
        StartCoroutine(preAttackDelay());
        yield return new WaitForSeconds(2);
        Attack();
        yield return new WaitForSeconds(Random.Range(15,30)); StartCoroutine(attackDelay());
    }

    IEnumerator preAttackDelay()
    {
        GameObject _preAttackZone = Instantiate(preAttack);
        _preAttackZone.transform.parent = transform;
        _preAttackZone.transform.position = preAttackSpawnPoint.transform.position;
        yield return new WaitForSeconds(2); Destroy(_preAttackZone);
    }

    public void Attack()
    {
        Instantiate(attack).transform.position = attackSpawnPoint.transform.position;
    }
}
