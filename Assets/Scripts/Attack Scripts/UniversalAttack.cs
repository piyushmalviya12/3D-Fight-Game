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
    public GameObject hit_FX;

    private void Update()
    {
        DetectCollision();
    }

    public void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position,radius,collosionLayer);

        if(hit.Length > 0)
        {
        print(hit[0].gameObject.name);
        }
    }
}
