using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalAttack : MonoBehaviour
{
    public LayerMask collosionLayer;
    
    public bool isPlayer;
    public bool isEnemy;
    public float radius =1f;
    public float damage = 2f;
    public GameObject hit_FX_Prefabs;

    private void Update()
    {
        DetectCollision();
    }

    public void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position,radius,collosionLayer);

        if(hit.Length > 0)
        {
            if (isPlayer)
            {

                Vector3 hitFX_pos = hit[0].transform.position;
                hitFX_pos.y += 1.3f;

                if (hit[0].transform.position.x > 0)
                {
                    hitFX_pos.x += 0.3f;
                }
                else if (hit[0].transform.position.x < 0)
                {
                    hitFX_pos.x -= 0.3f;
                }

                Instantiate(hit_FX_Prefabs, hitFX_pos, Quaternion.identity);

                if (gameObject.CompareTag(Tags.LEFT_ARM_TAG) ||
                    gameObject.CompareTag(Tags.LEFT_LEG_TAG))
                {
                    hit[0].GetComponent<CharactersHealth>().ApplyDamage(damage, true);
                }
                else
                {
                    hit[0].GetComponent<CharactersHealth>().ApplyDamage(damage, false);
                }

            }
         print("We Hit The "+hit[0].gameObject.name);
            gameObject.SetActive(false);

        }
    }
}
