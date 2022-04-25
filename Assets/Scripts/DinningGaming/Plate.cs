using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public Transform parent;
    public GameObject[] foodPoints;
    public int foodLocation = 0;
    private bool posOne,posTwo,posThree;
    public Collider plateCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        // if (collider.CompareTag("Food")){
           
        //         collider.transform.SetParent(parent);
        //         collider.transform.position = foodPoints[foodLocation].transform.position;
        //         collider.attachedRigidbody.isKinematic = true;
        //         collider.attachedRigidbody.useGravity = false;
        //         collider.attachedRigidbody.detectCollisions = false;
        //         foodLocation++;

        // }
        
    switch(collider.tag){
            case "Kebab":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                foodLocation++;

            break;
            case "Porkchop":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                foodLocation++;
            break;
            case "Steak":
                 collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                foodLocation++;
            break;
            case "Orange":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                foodLocation++;
            break;
            case "Tomato":
              collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                foodLocation++;
            break;
}

        if (foodLocation >=3){
                    plateCol.isTrigger = false;
            }

        }

}


   
