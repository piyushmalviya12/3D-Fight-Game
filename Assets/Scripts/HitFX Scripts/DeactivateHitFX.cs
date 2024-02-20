using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateHitFX : MonoBehaviour
{
    public float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateAfterTime", timer);
    }

  public void  DeactivateAfterTime()
    {
        gameObject.SetActive(false);
    }
}
