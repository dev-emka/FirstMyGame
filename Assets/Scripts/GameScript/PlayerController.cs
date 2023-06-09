using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myrb;
    public float hiz;
    public bool isPlay,isfinal;
    public int puan;
    public Text puantxt;
    public GameObject finalypota,deadscreen,gamescreen;
    public Levelone levelone;
    
    private void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        isPlay = true;
        Time.timeScale = 0;
        puan = (levelone.level * 10) - 10;
        puantxt.text = puan.ToString();
        
    }

    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0)&&isPlay)
        {
            myrb.velocity=(Vector2.up*hiz)+(Vector2.right*hiz/100);
            Time.timeScale = 1;
        }
        if (puan == ((levelone.level*10)-(1)))
        {
            isfinal = true;
            finalypota.SetActive(true);
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "gecisobjesi")
        {
            puan += 1;
            puantxt.text = puan.ToString();
            Destroy(collision.gameObject);
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin" || collision.gameObject.tag == "sinirlar")
        {
            
            deadscreen.SetActive(true);
            gamescreen.SetActive(false);
            isPlay = false;
        }
    }

}
