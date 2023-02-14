using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowbell_pawner : MonoBehaviour
{
    public double maxTime = 1;
    private float timer = 0;
    public GameObject cowbell;
    public float height;
    void Start()
    {
        GameObject newcow = Instantiate(cowbell);
        newcow.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newcow = Instantiate(cowbell);
            newcow.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newcow, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
