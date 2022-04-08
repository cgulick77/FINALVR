using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
     public float gravity = -9.81f;
    public LayerMask groundLayer;
    private float fallingSpeed;
    private CharacterController character;
     
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isGrounded = CheckIfGrounded();
        if (isGrounded)
            fallingSpeed = 0;
        else 
        fallingSpeed += gravity * Time.fixedDeltaTime;
        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);
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
