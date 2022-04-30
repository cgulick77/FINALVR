using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShower : MonoBehaviour
{
    public GameObject showerHead;
    public GameObject[] food;
    public float coolDownTime = .7f;
    public bool loaded;
    public bool onPlate, playerNearStand;
    public LayerMask groundLayer;
    public bool leftDirection, forwardDirection, backwardDirection, rightDirection, currDirecton;
    private float angleForce, forwardForce, zForce;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if (playerNearStand == true)
      {
           StartCoroutine(ShowerFood());
      }
    }
   IEnumerator ShowerFood()
   {
       
       yield return new WaitForSeconds(coolDownTime);
        DirectionFiring();

        // Angle used for firing the food
        angleForce = Random.Range(20, 30);

        //Randomizes which food is selected for firing food
        int foodRng = Random.Range(0,food.Length);

        //Instantiates the food item, gets rigidbody, adds force to object
       GameObject foodItem = Instantiate(food[foodRng],showerHead.transform.position,showerHead.transform.rotation);
        Rigidbody foodRb = foodItem.GetComponent<Rigidbody>();
        foodRb.AddForce(forwardForce, angleForce,zForce,ForceMode.Impulse);
        StartCoroutine(ShowerFood());
       
      
    
   }

    void OnTriggerEnter(Collider collider) {
       if(collider.CompareTag("Plate"))
       {
           onPlate = true;
       } 

       if (collider.CompareTag("Player"))
       {
           playerNearStand = true;
       }
   }

    //Changes the direction its firing depending on which settig is clicked.
   void DirectionFiring()
    {
       if (forwardDirection == true)
       {
             forwardForce = Random.Range(50,70);
             zForce = Random.Range(0,0);
       }
        if (backwardDirection == true)
       {
            forwardForce = Random.Range(-45,-70);
            zForce = Random.Range(0,0);
       }
        if (leftDirection == true)
       {
            zForce = Random.Range(50,70);
            forwardForce = Random.Range(0,0);
       }
        if (rightDirection == true)
       {
            zForce = Random.Range(-50,-70);
            forwardForce = Random.Range(0,0);
       }
            
    }
}
