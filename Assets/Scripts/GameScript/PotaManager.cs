using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PotaManager : MonoBehaviour
{
    Levelone levelone;
    Collisons collisons;
    public float levelSpeed,speed, lifeTime;
    PlayerController ball;
    GameObject balls;
    public BoxCollider2D box;
    Animator myanim;
    bool isDead;
    private void Start()
    {
        myanim = GetComponent<Animator>();
        Destroy(gameObject, lifeTime);
        ball = FindObjectOfType<PlayerController>();
        balls = GameObject.Find("top");
        levelone = FindObjectOfType<Levelone>();
        collisons = transform.GetChild(2).GetComponent<Collisons>();
        box = transform.GetChild(3).GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        
        float birinci = transform.position.x;
        float ikinci = balls.transform.position.x;
        float mesafe = birinci-ikinci;
        levelSpeed = levelone.level*1.5f;
        if (collisons.isCol)
        {
            box.isTrigger = true;
        }
        else
        {
            box.isTrigger = false;
        }
        if (mesafe < -1f)
        {
            isDead = true;
            myanim.SetBool("isDead", isDead);
            Destroy(gameObject,1f);
        }

        if (!ball.isfinal)
        {
            transform.position += Vector3.left * speed *levelSpeed *Time.deltaTime;
        }
        else
        {
            isDead = true;
            myanim.SetBool("isDead", isDead);
            Destroy(gameObject);
            
        }
        
    }
    

}
