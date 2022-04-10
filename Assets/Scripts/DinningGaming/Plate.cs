using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public Transform parent;
    public GameObject[] foodPoints;
    private int foodLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Food")){
            while (foodLocation <=2)
            {
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.attachedRigidbody.isKinematic = true;
                collider.attachedRigidbody.useGravity = false;

            }

            foodLocation +=1;
           
        }
    }
}


   
