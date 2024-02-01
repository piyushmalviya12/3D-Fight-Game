using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnemyMovement : MonoBehaviour
{

    private CharactersHealth playerHealth;

    private CharacterAnimation enemyAnim;

    private Rigidbody myBody;
    public float speed = 1.8f;

    private Transform playerTarget;

    public float attack_Distance = 1.3f;
    private float chase_Player_After_Attack = 1f;

    private float current_Attack_Time;
    private float default_Attack_Time=1f;

    private bool followPlayer, attackPlayer;

    private void Awake()
    {
         playerHealth = GetComponent<CharactersHealth>();

        enemyAnim = GetComponentInChildren<CharacterAnimation>();
        myBody = GetComponent<Rigidbody>();

        playerTarget = GameObject.FindWithTag(Tags.PLAYER_TAG).transform;
    }
    void Start()
    {
        followPlayer = true;
        current_Attack_Time = default_Attack_Time;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

   private void FixedUpdate()
    {
        FollowTarget(); // because of rigid body
    }
    private void FollowTarget()
    {
        // if we are not supposed to follow the player
        if (!followPlayer)
            return;

        
        if(Vector3.Distance(transform.position,playerTarget.position) > attack_Distance)
        {
            transform.LookAt(playerTarget);
            myBody.velocity = transform.forward * speed;


            // if we are not moving the suare magnitude is zero
            if(myBody.velocity.sqrMagnitude != 0)
            {
                enemyAnim.Walk(true);
            }

        }else if (Vector3.Distance(transform.position, playerTarget.position) <= attack_Distance)
        {
            myBody.velocity = Vector3.zero;
            enemyAnim.Walk(false);

            followPlayer = false;
            attackPlayer = true;
        }
    }  // follow Player

    public void Attack()
    {
        // if we not attack the player then exit the function
        if (!attackPlayer)
            return;

        current_Attack_Time += Time.deltaTime;

        if (current_Attack_Time > default_Attack_Time)
        {
            
            enemyAnim.EnemyAttack(UnityEngine.Random.Range(0, 3));
            current_Attack_Time = 0f;


            playerHealth.PlayerHealthBar();

        }

        // when enemy attack to the player and due to attack player back some inches
        if(Vector3.Distance(transform.position, playerTarget.position) > 
            attack_Distance + chase_Player_After_Attack)
        {
            attackPlayer = false;
            followPlayer = true;
        }
    } // attack

}   // class
