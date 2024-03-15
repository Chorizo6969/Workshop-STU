using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingMissile : MonoBehaviour
{
    public float speed;
    public Vector3 positionOfTargetToKill;
    public Vector3 lastTargetPosition;
    public GameObject target;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FindTarget());
        lastTargetPosition = transform.position + new Vector3(transform.position.x+10, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Déterminez la direction du point cible par rapport à la position actuelle de l'objet
        Vector2 directionToTarget = new Vector2(positionOfTargetToKill.x, positionOfTargetToKill.y) - (Vector2)this.transform.position;

        // Calculez l'angle en radians à partir de la direction vers le point cible
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
        angle -= 90;

        // Créez une rotation à partir de l'angle calculé
        Quaternion newRotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Appliquez la nouvelle rotation à l'objet
        this.transform.rotation = newRotation;

        if (target)
        {
            positionOfTargetToKill = target.transform.position;
            Vector3 _directionToGo = Vector3.MoveTowards(transform.position, lastTargetPosition, speed * Time.deltaTime);
            transform.position = _directionToGo;
        }
        if (!target)
        {
            Vector3 _directionToGo = Vector3.MoveTowards(transform.position, lastTargetPosition, speed * Time.deltaTime);
            transform.position = _directionToGo;
        }
        lastTargetPosition = positionOfTargetToKill;
        distance = (gameObject.transform.position - target.transform.position).magnitude;
        foreach (GameObject ennemy in FindAnyObjectByType<playerMissilePerimeter>().ennemy)
        {
            if (distance > (gameObject.transform.position - ennemy.transform.position).magnitude)
            {
                target = ennemy;
            }
            Ray ray = new Ray(transform.localPosition, ennemy.transform.localPosition);
            Debug.DrawRay(transform.localPosition, ennemy.transform.localPosition - transform.localPosition, Color.red);
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ennemyThings")
        {
            Destroy(gameObject);
        }
    }*/

    IEnumerator FindTarget()
    {
        Debug.Log("TROUVE UNE CBLE");
        if (target == null && FindAnyObjectByType<playerMissilePerimeter>().ennemy.Count >0)
        {
            Debug.Log("J'Ai PAS DE CIBLE DONC JE CHERCHE");

            target = FindAnyObjectByType<playerMissilePerimeter>().ennemy[0];
            positionOfTargetToKill = target.transform.position;
        }
        yield return new WaitForSeconds(0.5f); StartCoroutine(FindTarget());
    }
}