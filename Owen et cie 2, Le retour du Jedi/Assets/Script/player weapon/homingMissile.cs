using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingMissile : MonoBehaviour
{
    public int speed;
    public Vector3 positionOfTargetToKill;
    public Vector3 lastTargetPosition;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FindTarget());
        lastTargetPosition = transform.position + new Vector3(transform.position.x+10, 0, 0);
    }

    // Update is called once per frame
    void Update()
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

        if (!target)
        {
            Debug.Log("J'AI PAS DE CIBLE FDP");
            Vector3 _directionToGo = Vector3.MoveTowards(transform.position, lastTargetPosition, speed * Time.deltaTime);
            transform.position = _directionToGo;
        }
        else
        {
            Debug.Log("Un connard va bientot crever...");
            positionOfTargetToKill = target.transform.position;
            Vector3 _directionToGo = Vector3.MoveTowards(transform.position, lastTargetPosition, speed * Time.deltaTime);
            transform.position = _directionToGo;
        }
        lastTargetPosition = positionOfTargetToKill;
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
        Debug.Log("TROUVE UNE CIBLE CONNARD");
        if (target == null)
        {
            target = FindAnyObjectByType<Ennemy>().gameObject;
            positionOfTargetToKill = target.transform.position;
        }
        yield return new WaitForSeconds(1); StartCoroutine(FindTarget());
    }
}
