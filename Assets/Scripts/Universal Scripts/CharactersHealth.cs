using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersHealth : MonoBehaviour
{
    private CharacterAnimation animationScript;
    private HealthUI healthUI;
   


    public float health = 100f;
    public bool isPlayer;
    private bool characterDied;

   
    private void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
       
        

        if (isPlayer)
        {
            healthUI = GetComponent<HealthUI>();
        }
       
    }


    public void ApplyDamage(float damage, bool knockDown)
    {
        if (characterDied)
            return;

        health -= damage;
        if (isPlayer)
        {
            healthUI.DisplayHealth(health);
        }

        if(health <=0f)
        {
            animationScript.Death();
            characterDied = true;
          

            if (isPlayer)
            {
               
                GameObject.FindWithTag(Tags.ENEMY_TAG).GetComponent<EnemyMovement>().enabled = false;
             
                Debug.Log("Player Died");
                
                

            }
            return;
        }

        if (!isPlayer)
        {
            if (knockDown)
            {
                if (Random.Range(0, 2) > 0)
                {
                    animationScript.KnockDown();
                }
            }
            else
            {
             
                if (Random.Range(0, 3) > 1)
                {
                    animationScript.Hit();
                }
            }
        }


    }

}
