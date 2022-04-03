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
    public List<XRController> climbingHands = new List<XRController>(); 
     
    // Start is called before the first frame update 
    void Start() 
    { 
        controllerVelocity = FindObjectOfType<ControllerVelocity>(); 
        climableSurface = FindObjectOfType<ClimableSurface>(); 
    } 
 
    // Update is called once per frame 
     void FixedUpdate() { 
 
         if (hand) 
         { 
             Climb(); 
         } 
         
       
     } 
 
 
    public void Climb() 
    { 
        //Gets controllers velocity 
        Vector3 velocity = controllerVelocity ? controllerVelocity.velocity : Vector3.zero; 
        character.Move(transform.rotation * -velocity * Time.deltaTime * climbSpeed); 
    }    
 
     
 
} 