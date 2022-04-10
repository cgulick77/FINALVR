using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeClimber : MonoBehaviour
{


    public GameObject contactPoint;
    public GameObject axeFront;
    private List<GameObject> points = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("climbable"))
        {
            Debug.Log("Hit");
            Instantiate(contactPoint,axeFront.transform.position, axeFront.transform.rotation);
            
        }
    }
}
