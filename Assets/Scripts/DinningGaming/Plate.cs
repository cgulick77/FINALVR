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
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
        
    if (foodLocation != 1)
    {
    switch(collider.tag){
            case "Kebab":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
            case "Porkchop":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;
            break;
            case "Steak":
                 collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;
            break;
            case "Orange":
                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;
            break;
            case "Tomato":
              collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;
            break;
             case "Salmon":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Sushi":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Squid":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Lemonade":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Coffee":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Soda":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Donut":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "Pie":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;
             case "IceCream":

                collider.transform.SetParent(parent);
                collider.transform.position = foodPoints[foodLocation].transform.position;
                collider.gameObject.transform.position = foodPoints[foodLocation].transform.position;
                // collider.attachedRigidbody.isKinematic = true;
                // collider.attachedRigidbody.useGravity = false;
                // collider.attachedRigidbody.detectCollisions = false;
                //foodLocation++;

            break;

            default:
            
            break;
    }
}

        if (foodLocation >=3){
                    plateCol.isTrigger = false;
            }

        }

}


   
