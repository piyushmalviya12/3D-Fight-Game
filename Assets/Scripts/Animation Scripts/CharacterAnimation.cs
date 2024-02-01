using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        anim.SetBool(AnimationTags.MOVEMENT, move);
    }


    public void Punch_1()
    {
        anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
    }
    public void Punch_2()
    {
        anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
    }
    public void Punch_3()
    {
        anim.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
    }
    
    public void Defend()
    {
        anim.SetTrigger(AnimationTags.DEFEND_TRIGGER);
    }
    
    
    
    public void Kick_1()
    {
        anim.SetTrigger(AnimationTags.KICK_1_TRIGGER);
    }
    public void Kick_2()
    {
        anim.SetTrigger(AnimationTags.KICK_2_TRIGGER);
    }

    // Enemy Animation Tag

    public void EnemyAttack(int attack)
    {
        if (attack == 0)
        {
            anim.SetTrigger(AnimationTags.ATTACK_1_TRIGGER);
            
        } 
        if (attack == 1)
        {
            anim.SetTrigger(AnimationTags.ATTACK_2_TRIGGER);
           
        } 
        if (attack == 2)
        {
            anim.SetTrigger(AnimationTags.ATTACK_3_TRIGGER);
           
        }
    }  // enemy attack

    public void Play_IdleAnimation(){
        anim.Play(AnimationTags.IDLE_ANIMATION);
    }

    public void KnockDown()
    {
        anim.SetTrigger(AnimationTags.KNOCK_DOWN_TRIGGER);
    }
    public void StandUp()
    {
        anim.SetTrigger(AnimationTags.STAND_UP_TRIGGER);
    }
    public void Hit()
    {
        anim.SetTrigger(AnimationTags.HIT_TRIGGER);
    }
    public void Death()
    {
        anim.SetTrigger(AnimationTags.DEATH_TRIGGER);
    }

    internal void EnemyAttack(object p)
    {
        throw new NotImplementedException();
    }
}  //class
