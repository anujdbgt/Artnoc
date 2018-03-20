using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private CharacterController controller;
    private float verticalvelocity;

    [SerializeField]
    private float gravity = 25.0f;
    private float jumpforce = 15.0f;

    private float horizontalvelocity = 11.0f;

    private void Start()
    {
        //Creating refrence of the Charactercontroller
        controller = GetComponent<CharacterController>();
    }


    private void Update()
    {
        //If the player is in contact with ground a bit of gravity acts on the player and he can jump
        if (Grounded())
        {
            verticalvelocity = -gravity * Time.deltaTime;
            jump();
        }

        //If the player is in air gravity acts on the character

        if(!  Grounded())
            verticalvelocity -= gravity * Time.deltaTime;

        //Calling the movement function
        move();
    }

    private void move()
    {
        //Making the character move Horizontally and also vertically
        
        Vector2 moveVector = Vector2.zero;
        moveVector.x = Input.GetAxis("Horizontal") * horizontalvelocity;
        moveVector.y = verticalvelocity;


        controller.Move(moveVector * Time.deltaTime);
    }


    public bool Grounded()
    {
        //Checking if the player is grounded or not

        if (controller.isGrounded)
        {
            
            return true;

        }
        return false;

    }

    void jump()

        // Taking key input to jump
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            verticalvelocity = jumpforce;
        }

        

    }
}

        

