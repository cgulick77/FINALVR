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
        if (JobActivated == true)
            {
                Score.remainingOrder = GameManager.totalOrder;
                computerOn.SetActive(true);
                gameObject.SetActive(false);
            }
        else{
           
        }
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Card"))
        {
            JobActivated = true;
            
            //Debug.Log("Card");
        }
    }
}
