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

    private PlayerGravity playerGravity;
     
    // Start is called before the first frame update 
    void Start() 
    { 
        controllerVelocity = FindObjectOfType<ControllerVelocity>(); 
        climableSurface = FindObjectOfType<ClimableSurface>(); 
        playerGravity = GetComponent<PlayerGravity>();
    } 
 
    // Update is called once per frame 
     void Update() { 
 
         if (hand) 
         { 
             playerGravity.enabled = false;
             Climb(); 
         } 
         else
         {
             playerGravity.enabled = true;
         }
         
       
     } 
 
 
    public void Climb() 
    { 
        //Gets controllers velocity 
        Vector3 velocity = controllerVelocity ? controllerVelocity.velocity : Vector3.zero; 
        character.Move(transform.rotation * -velocity * Time.deltaTime ); 
    }    
 
     
 
} 