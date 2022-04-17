using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShower : MonoBehaviour
{
    public GameObject showerHead;
    public GameObject[] food;
    public float coolDownTime = .7f;
    public bool loaded;
    public bool onPlate;
    public LayerMask groundLayer;
    private float shootSpeed = 25f;
    public bool leftDirection, forwardDirection, backwardDirection, rightDirection, currDirecton;
    private float angleForce, forwardForce, zForce;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowerFood());
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   IEnumerator ShowerFood()
   {
       
       yield return new WaitForSeconds(coolDownTime);
        DirectionFiring();
        angleForce = Random.Range(10, 40);
       GameObject foodItem = Instantiate(food[2],showerHead.transform.position,showerHead.transform.rotation);
       Rigidbody foodRb = foodItem.GetComponent<Rigidbody>();
       foodRb.AddForce(forwardForce, angleForce,zForce,ForceMode.Impulse);
       //foodItem.transform.position = Vector3.MoveTowards(foodItem.transform.position, target.transform.position, shootSpeed* Time.deltaTime);
       StartCoroutine(ShowerFood());
    
   }

    void OnTriggerEnter(Collider collider) {
       if(collider.CompareTag("Plate"))
       {
           onPlate = true;
       }

       
   }

   void DirectionFiring()
    {
       if (forwardDirection == true)
       {
             forwardForce = Random.Range(35,70);
             zForce = Random.Range(0,0);
       }
        if (backwardDirection == true)
       {
            forwardForce = Random.Range(-35,-70);
            zForce = Random.Range(0,0);
       }
        if (leftDirection == true)
       {
            zForce = Random.Range(35,70);
            forwardForce = Random.Range(0,0);
       }
        if (rightDirection == true)
       {
            zForce = Random.Range(-35,-70);
            forwardForce = Random.Range(0,0);
       }
            
    }
}
