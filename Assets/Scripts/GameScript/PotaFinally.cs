using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotaFinally : MonoBehaviour
{
    public float sinir;
    Colfinally collisons;
    public BoxCollider2D box;
    private void Start()
    {
        collisons = transform.GetChild(1).GetComponent<Colfinally>();
    }
    void FixedUpdate()
    {
        float xhareket = Mathf.Sin(Time.time) * sinir;
        transform.position = new Vector2(xhareket, 0);

        if (collisons.isCollfin)
        {
            box.isTrigger = true;
        }
        else
        {
            box.isTrigger = false;
        }

        
    }
   


}
