using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public GameObject PauseScreen,deadScreen, GameScreen, startScreen, leveldesig,skipScreen;
    public Text startTxt;
    public Levelone levelone;
    public PlayerController playerscrpt;
    int level;
    public PotaManager potaManager;
    public SpawnManager spawnManager;

    
    void Start()
    {
        
        
        startTxt.text = "LEVEL" + "\n" + "\n" + levelone.level.ToString();
        fadeout();
        level = levelone.level;

    }

    void Update()
    {
        level = levelone.level;
          
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
        GameScreen.SetActive(false);
    }
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(level);
        
    }
    public void Continue()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        GameScreen.SetActive(true);
        StartCoroutine(spawnManager.spawnet());
    }
    public void SkipLevel()
    {

        SceneManager.LoadScene(level+1);
        
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }
    public void Linkmanager(string url)
    {
        Application.OpenURL(url);
    }
    void fadeout()
    {
        leveldesig.transform.GetComponent<CanvasGroup>().DOFade(0, 1.1f).OnComplete(() =>
        {
            startScreen.SetActive(false);
            GameScreen.SetActive(true);

        });

    }
           
    
    
}
