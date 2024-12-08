using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 7.0f; 
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 9.81f; 

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            movement = transform.TransformDirection(movement);
            movement *= speed;

            moveDirection = movement;

           
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

       
        moveDirection.y -= gravity * Time.deltaTime;

        
        controller.Move(moveDirection * Time.deltaTime);
    }
}
