using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersHealth : MonoBehaviour
{
    public Scrollbar player_HealthBar;
    public float player_BarSizeDecreaseBy = 0.03f;

    private CharacterAnimation player_Anim;
    /*public Scrollbar enemy_HealthBar;
    public float enemy_BarSizeDecreaseBy = 0.03f;*/


   
    private void Awake()
    {
        player_Anim = GetComponentInChildren<CharacterAnimation>();
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
   
}
