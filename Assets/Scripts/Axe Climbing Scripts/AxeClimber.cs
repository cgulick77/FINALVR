using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeClimber : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject contactPoint;
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
        }
    }
}
