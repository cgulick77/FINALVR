using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ClimableSurface : XRGrabInteractable
{
    private ControllerVelocity controllerVelocity = null;
    private Climber climber;
    private PlayerGravity playerGravity;
    public bool hand;

    //  void Start() {
    //     XRBaseInteractor interactor = selectingInteractor;

    //     IXRSelectInteractor newInteractor = firstInteractorSelecting;

    //     List<IXRSelectInteractor> moreInteractors = interactorsSelecting;
    // }
     void Start() {
        climber = FindObjectOfType<Climber>();
        playerGravity = FindObjectOfType<PlayerGravity>();
    }
        protected override void Awake()
    {
        base.Awake();
       
      
        
    }
    
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        controllerVelocity = args.interactor.GetComponent<ControllerVelocity>();

        
             climber.hand = args.interactor.GetComponent<XRController>();
        
       
        //XRController controller = args.interactorObject;
      //Debug.Log("Enter");

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        //controllerVelocity = null;

      
             if (climber.hand && climber.hand.name == args.interactor.name)
             {
                 climber.hand = null;
             }
        
         //Debug.Log("Exit");
    }
    
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (isSelected)
        {
        //    if (hand == true)
        //    {
        //        climber.RightClimb();
        //    }
        //    else if (hand == false)
        //    {
        //        climber.LeftClimb();
        //    }
            //if (IsSelectableBy)
            climber.RightClimb();
            //climber.LeftClimb();
            if(updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
            {
                
                //climber.RightClimb();
                //climber.RightClimb();
               //layerGravity.enabled = false;
                //Debug.Log(climber.hand.name);

            }
            else
            {
                //playerGravity.enabled = true;
                 //Debug.Log("Off");
            }

            

        }

        
    }

     void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.CompareTag("Left"))
        {
            hand = false;
        }

        if (collider.gameObject.CompareTag("Right"))
        {
            hand = true;
        }
    }

    
}
