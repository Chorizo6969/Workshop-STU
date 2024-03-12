using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingMissile : MonoBehaviour
{
    public int speed;
    public Vector3 positionOfTargetToKill;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = FindAnyObjectByType<Ennemy>().gameObject;
        positionOfTargetToKill = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        positionOfTargetToKill = target.transform.position;
        // Déterminez la direction du point cible par rapport à la position actuelle de l'objet
        Vector2 directionToTarget = new Vector2(positionOfTargetToKill.x, positionOfTargetToKill.y) - (Vector2)this.transform.position;

        // Calculez l'angle en radians à partir de la direction vers le point cible
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
        angle -= 90;

        // Créez une rotation à partir de l'angle calculé
        Quaternion newRotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Appliquez la nouvelle rotation à l'objet
        this.transform.rotation = newRotation;

        positionOfTargetToKill = target.transform.position;
        Vector3 _directionToGo = Vector3.MoveTowards(transform.position, positionOfTargetToKill, speed * Time.deltaTime);
        transform.position = _directionToGo;
    }
}
