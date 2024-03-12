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
        // D�terminez la direction du point cible par rapport � la position actuelle de l'objet
        Vector2 directionToTarget = new Vector2(positionOfTargetToKill.x, positionOfTargetToKill.y) - (Vector2)this.transform.position;

        // Calculez l'angle en radians � partir de la direction vers le point cible
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
        angle -= 90;

        // Cr�ez une rotation � partir de l'angle calcul�
        Quaternion newRotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Appliquez la nouvelle rotation � l'objet
        this.transform.rotation = newRotation;

        positionOfTargetToKill = target.transform.position;
        Vector3 _directionToGo = Vector3.MoveTowards(transform.position, positionOfTargetToKill, speed * Time.deltaTime);
        transform.position = _directionToGo;
    }
}
