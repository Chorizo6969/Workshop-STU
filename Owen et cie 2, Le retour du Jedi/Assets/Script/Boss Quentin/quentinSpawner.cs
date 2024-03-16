using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quentinSpawner : MonoBehaviour
{
    public List<GameObject> spawnerList;
    public List<GameObject> ennemyList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerRoutine());
    }

   IEnumerator SpawnerRoutine()
    {
        GameObject newEnnemy = Instantiate(ennemyList[Random.Range(0,ennemyList.Count)]);
        newEnnemy.transform.position = spawnerList[Random.Range(0, spawnerList.Count)].transform.position + new Vector3(-0.5f, 0, 0);

        yield return new WaitForSeconds(2.5f); StartCoroutine(SpawnerRoutine());
    }
}
