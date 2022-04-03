using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class Climber : MonoBehaviour
{
    public CharacterController character;
    public  XRController hand;
    private ControllerVelocity controllerVelocity;
    public LayerMask groundLayer;
    private ClimableSurface climableSurface;
    public float gravity = -9.81f;
    private float fallingSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        controllerVelocity = FindObjectOfType<ControllerVelocity>();
        climableSurface = FindObjectOfType<ClimableSurface>();
    }

    // Update is called once per frame
     void FixedUpdate() {
        
      bool isGrounded = CheckIfGrounded();
        if (isGrounded)
        {
             fallingSpeed = 0;
        }
        else {
        fallingSpeed += gravity * Time.fixedDeltaTime;
        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);
        }
    }

    public void Climb()
    {
        Vector3 velocity = controllerVelocity ? controllerVelocity.velocity : Vector3.zero;
        character.Move(transform.rotation * -velocity * Time.deltaTime);
    }   

    bool CheckIfGrounded()
    {
        //tells us if on ground
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLegth = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLegth, groundLayer);
        return hasHit;
    
    }

}
