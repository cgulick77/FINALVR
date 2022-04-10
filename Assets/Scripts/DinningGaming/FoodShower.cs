using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShower : MonoBehaviour
{
    public GameObject showerHead;
    public GameObject tomato;
    public float coolDownTime = 1.0f;
    public bool loaded;
    private bool onPlate;
    public LayerMask groundLayer;

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
       GameObject foodItem = Instantiate(tomato,showerHead.transform.position,showerHead.transform.rotation);
       StartCoroutine(ShowerFood());
    
   }

    void OnTriggerEnter(Collider collider) {
       if(collider.CompareTag("Plate"))
       {
           onPlate = true;
       }
   }
}
