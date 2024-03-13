using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityLife : MonoBehaviour
{
    public int life;

    private void FixedUpdate()
    {
        if (life <= 0)
        {
            if (GetComponent<Ennemy>())
            {
                GetComponent<Ennemy>().OnDeath();
            }
            Destroy(gameObject);
        }
    }
}
