using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float timeToFull, maxFloat;
    private float floatStrength, timer;
    private Vector3 startPos, currPos;
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        floatStrength = timer;
        timer = 0;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(Vector3.up * floatStrength);
        timer += Time.deltaTime;
        floatStrength = timer;
        if (timer >= timeToFull)
        {
            timer = maxFloat;
        }
        //currPos = transform.position;
        //if (currPos.y < startPos.y)
        //{
        //    transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
        //}
    }
}
