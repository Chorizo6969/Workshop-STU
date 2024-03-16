using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBossSpawn : MonoBehaviour
{
    public GameObject bossSpawn;
    public List<GameObject> healthBar;
    public GameObject Destroy_song;
    public AudioSource Boss_song;
    public GameObject blackScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Destroy_song);
            Boss_song.Play();
            Instantiate(bossSpawn);
            if (bossSpawn.name == "BossQuentin")
            {
                foreach (GameObject go in healthBar)
                {
                    go.SetActive(true);
                }
            }
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 2);
    }
}
