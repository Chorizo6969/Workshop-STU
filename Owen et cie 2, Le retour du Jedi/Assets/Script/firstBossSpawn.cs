using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBossSpawn : MonoBehaviour
{
    public GameObject bossSpawn;
    public List<GameObject> healthBar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(bossSpawn);
            if (bossSpawn.name == "BossQuentin")
            {
                foreach (GameObject go in healthBar)
                {
                    go.SetActive(true);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 2);
    }
}
