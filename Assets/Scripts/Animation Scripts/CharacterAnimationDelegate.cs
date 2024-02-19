using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
   public GameObject leftHandAttackPoint, rightHandAttackPoint ,leftLegAttackPoint ,rightLegAttackPoint;

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




}
