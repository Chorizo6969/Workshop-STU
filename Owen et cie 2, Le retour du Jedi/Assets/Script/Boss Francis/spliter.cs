using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spliter : MonoBehaviour
{
    public GameObject splitObject;
    public int delay;
    public float timer;
    public Vector3 direction;
    private bool hasSplit = false;

    private void Start()
    {
        direction = GetComponent<miniInterMove>().direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasSplit)
        {
            timer += Time.deltaTime;
        }
        if (timer >= delay)
        {
            GameObject newMiniInter1 = Instantiate(splitObject);
            newMiniInter1.transform.position = transform.position;
            newMiniInter1.GetComponent<miniInterMove>().direction = direction + new Vector3(0, 0.5f, 0);
            newMiniInter1.GetComponent<miniInterMove>().speed = GetComponent<miniInterMove>().speed + 1;

            GameObject newMiniInter2 = Instantiate(splitObject);
            newMiniInter2.transform.position = transform.position;
            newMiniInter2.GetComponent<miniInterMove>().direction = direction + new Vector3(0, -0.5f, 0);
            newMiniInter2.GetComponent<miniInterMove>().speed = GetComponent<miniInterMove>().speed + 1;

            hasSplit = true;
            timer = 0;
        }
    }
}
