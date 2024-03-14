using UnityEngine;

public class Heal : MonoBehaviour
{
    public Life soin;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            soin.Heal(20);
            Destroy(this.gameObject);
        }
    }
}
