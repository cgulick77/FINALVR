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
    private ClimableSurface climableSurface; 
    public float climbSpeed; 
    private PlayerGravity playerGravity;
    private LeftControllerVelocity leftControllerVelocity;
     
    // Start is called before the first frame update 
    void Start() 
    { 
        controllerVelocity = FindObjectOfType<ControllerVelocity>(); 
        climableSurface = FindObjectOfType<ClimableSurface>(); 
        playerGravity = GetComponent<PlayerGravity>();
        leftControllerVelocity =  FindObjectOfType<LeftControllerVelocity>();
    } 
 
    // Update is called once per frame 
     void FixedUpdate() { 
 
        //  if (hand) 
        //  { 
        //      playerGravity.enabled = false;
        //      //Climb(); 
        //  } 
        //  else
        //  {
        //      playerGravity.enabled = true;
        //  }
         
       
     } 
 
 
    public void RightClimb() 
    { 
        //Gets controllers velocity 
        Vector3 rightVelocity = controllerVelocity ? controllerVelocity.rightVelocity : Vector3.zero; 
        character.Move(transform.rotation * -rightVelocity * Time.deltaTime ); 
    }    

     public void LeftClimb() 
    { 
        //Gets controllers velocity 
        Vector3 leftVelocity = leftControllerVelocity ? leftControllerVelocity.leftVelocity : Vector3.zero; 
        character.Move(transform.rotation * -leftVelocity * Time.deltaTime ); 
    }    
 
     
 
} 