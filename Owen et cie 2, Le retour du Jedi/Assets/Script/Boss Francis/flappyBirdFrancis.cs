using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyBirdFrancis : MonoBehaviour
{
    public GameObject barre;
    private int countLimit = 4;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnABarre());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnABarre()
    {
        if (counter <= countLimit)
        {
            GameObject newBarre = Instantiate(barre);
            newBarre.transform.position = new Vector3(Random.Range(-8, 1), 4, 0);
            yield return new WaitForSeconds(2); counter++; StartCoroutine(spawnABarre());
        }
        
    }
}
