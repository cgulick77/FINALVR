using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class ControllerVelocity : MonoBehaviour
{

    public InputActionProperty velocityProperty;
    //public InputActionProperty leftVelocity;
    public Vector3 rightVelocity {get; private set;} = Vector3.zero;
    //public CharacterController character; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          rightVelocity = velocityProperty.action.ReadValue<Vector3>();
          
    }

   
}
