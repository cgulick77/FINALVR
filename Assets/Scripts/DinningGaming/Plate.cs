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
    public bool[] foodOnPlate;
    private bool collided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
    if (collided == false)
    {
    switch(collider.tag){
            case "Kebab":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
            case "Porkchop":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                
            break;
            case "Steak":
                 collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                
            break;
            case "Orange":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                
            break;
            case "Tomato":
              collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                
            break;
             case "Salmon":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "Sushi":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "Squid":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                
            break;
             case "Lemonade":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "Water":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "Cake":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "Pie":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;
             case "IceCream":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                collided = true;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                

            break;

            default:
            
            break;
    }
}

        // if (foodLocation >=3){
        //             plateCol.isTrigger = false;
        //     }

        }

}


   
