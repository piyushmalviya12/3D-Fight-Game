using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    private Rigidbody _myBody;
    private CharacterAnimation player_Anim;

    public float walk_Speed = 2f;
    public float z_Speed = 1.5f;
    

    private float rotation_Y= -90f;
    private float roation_Speed = 15f;

    
    private void Awake()
    {
        _myBody = GetComponent<Rigidbody>();
        player_Anim = GetComponentInChildren<CharacterAnimation>();

        
    }
    private void Update()
    {
        RotatePlayer();
    }
    private void FixedUpdate()
    {
        DetectMovement();
    }
    private void DetectMovement()
    {
        _myBody.velocity = new Vector3(
            Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) * (-walk_Speed),
            _myBody.velocity.y,
            Input.GetAxisRaw(Axis.VERTICAL_AXIS) * (-z_Speed)
            );
        AnimatePlayerWalk();
    }

    private void RotatePlayer()
     {
        if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) > 0)
        {
            transform.rotation = Quaternion.Euler(0f, rotation_Y, 0f);
            
        }
        else if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0f); //absolute (Abs) for non negative  and Mathf is collections of math functions
           
        }
     }

    private void AnimatePlayerWalk()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS)!=0 ||Input.GetAxisRaw(Axis.VERTICAL_AXIS)!=0)
        {
            player_Anim.Walk(true);
        }
        else
        {
            player_Anim.Walk(false);
        }
    }

    
}
