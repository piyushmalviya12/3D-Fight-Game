using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    PlayerMovement playerControls;
    EnemyMovement enemyControls;
    CharacterAnimation animationControls;
   /* public GameObject enemyanimationControls;*/


    private void Awake()
    {
        playerControls.enabled = false;
        enemyControls.enabled = false;
        animationControls.enabled = false;
        /* playerControls = GetComponent<PlayerMovement>();
         enemyControls = GetComponent<EnemyMovement>();
         animationControls = GetComponent<CharacterAnimation>();*/
        /*  enemyanimationControls = GetComponent<CharacterAnimation>().gameObject;*/
    }
    public void EnableControls()
    {
        /*playerControls.SetActive(true);
        enemyControls.SetActive(true);
        playeranimationControls.SetActive(true);
        enemyanimationControls.SetActive(true);*/
        playerControls.enabled = true;
        enemyControls.enabled = true;
        animationControls.enabled = true;
    }
    public void DisableControls()
    {
        /* playerControls.SetActive(false);
         enemyControls.SetActive(false);
         playeranimationControls.SetActive(false);
         enemyanimationControls.SetActive(false);*/
        playerControls.enabled = false;
        enemyControls.enabled = false;
        animationControls.enabled = false;
    }
}
