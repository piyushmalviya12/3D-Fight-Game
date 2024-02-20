using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
   private EnemyMovement enemyMovement;
   public GameObject leftHandAttackPoint, rightHandAttackPoint ,leftLegAttackPoint ,rightLegAttackPoint;
   public float standUp_Time = 2f;
   private CharacterAnimation animationScript;

    private AudioSource audioSource;

    [SerializeField]
    private AudioClip whooshSound, fall_Sound, groundHit_Sound, dead_Sound;

    private void Awake()
    {
        animationScript = GetComponent<CharacterAnimation>();
        audioSource = GetComponent<AudioSource>();
        if (gameObject.CompareTag(Tags.ENEMY_TAG))
        {
            enemyMovement = GetComponentInParent<EnemyMovement>();
        }
    }

    public void LeftHandAttackPointOn()
    {
            leftHandAttackPoint.SetActive(true);
    }
    public void LeftHandAttackPointOff()
    {
        if (leftHandAttackPoint.activeInHierarchy)
        {
            leftHandAttackPoint.SetActive(false);
        }
    }
    public void RightHandAttackPointOn()
    {
      
            rightHandAttackPoint.SetActive(true);
       
    }
    public void RightHandAttackPointOff()
    {
        if (rightHandAttackPoint.activeInHierarchy)
        {
            rightHandAttackPoint.SetActive(false);
        }
    }

    public void LeftLegAttackPointOn()
    {

        leftLegAttackPoint.SetActive(true);

    }
    public void LeftLegAttackPointOff()
    {
        if (leftLegAttackPoint.activeInHierarchy)
        {
            leftLegAttackPoint.SetActive(false);
        }
    }

    public void RightLegAttackPointOn()
    {
      
            rightLegAttackPoint.SetActive(true);
       
    }
    public void RightLegAttackPointOff()
    {
        if (rightLegAttackPoint.activeInHierarchy)
        {
            rightLegAttackPoint.SetActive(false);
        }
    }

    public void Tag_LeftArm()
    {
        leftHandAttackPoint.tag = Tags.LEFT_ARM_TAG;
    } 
    public void UnTag_LeftArm()
    {
        leftHandAttackPoint.tag = Tags.UNTAGGED_TAG;
    }

    public void Tag_LeftLeg()
    {
        leftLegAttackPoint.tag = Tags.LEFT_LEG_TAG;
    } 
    public void UnTag_LeftLeg()
    {
        leftLegAttackPoint.tag = Tags.UNTAGGED_TAG;
    }

    public void Enemy_StandUp()
    {
        StartCoroutine(StandUp_AfterTime());
    }

    IEnumerator StandUp_AfterTime()
    {
        yield return new WaitForSeconds(standUp_Time);
        animationScript.StandUp();
    }
}
