using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ClimableSurface : XRGrabInteractable
{
    private ControllerVelocity controllerVelocity = null;
    private Climber climber;
    public bool entered;

    //  void Start() {
    //     XRBaseInteractor interactor = selectingInteractor;

    //     IXRSelectInteractor newInteractor = firstInteractorSelecting;

    //     List<IXRSelectInteractor> moreInteractors = interactorsSelecting;
    // }
        protected override void Awake()
    {
        base.Awake();
        climber = FindObjectOfType<Climber>();

      
        
    }
    
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        controllerVelocity = args.interactor.GetComponent<ControllerVelocity>();
        climber.hand = args.interactor.GetComponent<XRController>();
        //XRController controller = args.interactorObject;
      

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        controllerVelocity = null;
         
    }
    
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (isSelected)
        {
            if(updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
            {
                
                climber.Climb();
            }

        }
    }
}
