using UnityEngine;

public class entityLife : MonoBehaviour
{
    public int life;
    public GameObject panel_retry;
    public Eventsystemnavigation loose;

    private void FixedUpdate()
    {
        if (life <= 0)
        {
            if (GetComponent<Ennemy>())
            {
                GetComponent<Ennemy>().OnDeath();
            }
            Destroy(gameObject);
            if (gameObject.tag == "Player")
            {
                loose.Change_WeaponsL2();
                panel_retry.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
