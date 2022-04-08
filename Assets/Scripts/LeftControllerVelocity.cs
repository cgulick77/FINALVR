using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 
using UnityEngine.XR; 
using UnityEngine.InputSystem; 
 
public class LeftControllerVelocity : MonoBehaviour
{
    public InputActionProperty velocityProperty;
    public Vector3 leftVelocity {get; private set;} = Vector3.zero;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftVelocity = velocityProperty.action.ReadValue<Vector3>();
    }

   
}
