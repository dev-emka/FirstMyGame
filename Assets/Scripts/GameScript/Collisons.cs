using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisons : MonoBehaviour
{
    //PotaManager PotaManager;
    public bool isCol;
    void Start()
    {
        //PotaManager = FindObjectOfType<PotaManager>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "top")
        {
            isCol = true;     
        }
    }
}
