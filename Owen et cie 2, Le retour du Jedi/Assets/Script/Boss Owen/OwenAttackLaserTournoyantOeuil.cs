using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwenAttackLaserTournoyantOeuil : MonoBehaviour
{
    public int speed;
    public GameObject preAttackObject;
    public GameObject attackObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AttackDelay());
    }

    IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(10); 
        StartCoroutine(preAttackZone());
        yield return new WaitForSeconds(2);
        AttackDeLaMortQuiTue();
        StartCoroutine(AttackDelay());
    }

    IEnumerator preAttackZone()
    {
        GameObject _preAttackObject = Instantiate(preAttackObject);
        yield return new WaitForSeconds(2); Destroy(_preAttackObject); 
    }

    public void AttackDeLaMortQuiTue()
    {
        Instantiate(attackObject);
    }
}