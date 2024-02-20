using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersHealth : MonoBehaviour
{
    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;

    public Scrollbar player_HealthBar;
    public float player_BarSizeDecreaseBy = 0.03f;

    public float health = 100f;
    public bool isPlayer;
    private bool characterDied;

   
    /*public Scrollbar enemy_HealthBar;
    public float enemy_BarSizeDecreaseBy = 0.03f;*/


   
    private void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
    }

    // Player

    public void PlayerHealthBar()
    {
        if (player_HealthBar.size != 0)
        {
            player_HealthBar.size -= player_BarSizeDecreaseBy;
        }
        if(player_HealthBar.size == 0)
        {
            //player_Anim.Death();
        }
       
    }
    
    // Enemy
   /* public void EnemyHealthBar()
    {
        enemy_HealthBar.size -= enemy_BarSizeDecreaseBy;
    }*/
   
    public void ApplyDamage(float damage, bool knockDown)
    {
        if (characterDied)
            return;

        health -= damage;

        if(health <=0f)
        {
            animationScript.Death();
            characterDied = true;

            if (isPlayer)
            {

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
                animationScript.Hit();
                /* if (Random.Range(0, 3) > 1)
                 {
                     animationScript.Hit();
                 }*/
            }
        }


    }

}
