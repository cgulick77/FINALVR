using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public Collider objCollider;
    public Rigidbody foodRb;
    public Collider secondCol;
    
    
    
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
            foodRb.isKinematic = true;
            foodRb.useGravity = false;
            secondCol.enabled = true;

        }
        if (collider.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
        if (collider.CompareTag("Table"))
        {
            objCollider.enabled = true;
        }


    }

    
}
