using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Levelone : MonoBehaviour
{
    public PlayerController pycs;
    public GameObject skipScreen,gameScreen;
    public int level;
    public bool levelOne,levelTwo,levelThree,levelFour,levelFive;

    public Text skipText;
    private void Awake()
    {
        level = SceneManager.GetActiveScene().buildIndex;
    }
    void Start()
    {

        levelOne = true;
        
    }

    
    void Update()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        
        if (pycs.puan == (level*10))
        {
            
            
            skipText.text = "LEVEL"+level.ToString() + "\n" + "COMPLETED";
            gameScreen.SetActive(false);
            skipScreen.SetActive(true);
        }
    }
}
