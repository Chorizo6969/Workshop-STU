using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerQuentin : MonoBehaviour
{
    public int speed;
    public GameObject quentin;
    public int moveY = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ATTEND());
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 5)
        {
            moveY = -1;
        }
        if (transform.position.y <= -5)
        {
            moveY = 1;
        }
        transform.Translate(new Vector3 (0, moveY, 0) * Time.deltaTime * speed);
    }

    IEnumerator SpawnDeQuentin()
    {
        GameObject newQuentin = Instantiate(quentin);
        newQuentin.transform.position = transform.position;
        yield return new WaitForSeconds(3); StartCoroutine(SpawnDeQuentin());
    }

    IEnumerator ATTEND()
    {
        yield return new WaitForSeconds (10); StartCoroutine(SpawnDeQuentin());
    }
}
