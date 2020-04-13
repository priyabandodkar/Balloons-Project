using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject arriveHere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Respawn")
        {
            Transform other = collider.gameObject.transform.root;
            Instantiate(other, new Vector3(arriveHere.transform.position.x, arriveHere.transform.position.y, arriveHere.transform.position.z), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
