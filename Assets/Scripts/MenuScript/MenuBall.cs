using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MenuBall : MonoBehaviour
{
    float hiz = 2;

    void Update()
    {
        float yMove = Mathf.Sin(Time.time) * hiz;
         transform.position = new Vector2(0, yMove);

        
    

    }
}
