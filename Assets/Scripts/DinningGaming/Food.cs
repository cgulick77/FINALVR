using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public Collider objCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Plate"))
        {
            objCollider.enabled = false;
        }
        if (collider.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }

    }
}
