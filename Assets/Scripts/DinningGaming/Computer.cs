using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public static bool JobActivated;
    public GameObject computerOn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Activated sets the current orders to the total number of orders, sets the "Off computer game object" inactive and activated the "On Computer Object"
        if (JobActivated == true)
            {
                Score.remainingOrder = GameManager.totalOrder;
                computerOn.SetActive(true);
                gameObject.SetActive(false);
            }
        else{
           
        }
    }

    //If the computer collides with a "Card", activated the computer
    private void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Card"))
        {
            JobActivated = true;
            
            //Debug.Log("Card");
        }
    }
}
