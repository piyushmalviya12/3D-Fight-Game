using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   public static  EnemyManager instance;

    [SerializeField]
    private GameObject enemy_Prefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void EnemySpawn()
    {
        Instantiate(enemy_Prefab, transform.position, Quaternion.identity);
    } 
}
