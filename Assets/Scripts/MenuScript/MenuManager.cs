using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{

    
    
    public List<GameObject> buttons = new List<GameObject>();
    private void Start()
    {
        Fadeout();
        buttons[0].transform.DORotate(new Vector3(0, 0, 360), 3f, RotateMode.WorldAxisAdd);
       
    }
    
    public void playtick()
    {
        SceneManager.LoadScene(1);
    }
    public  void ExitTick()
    {
        Application.Quit();
    }
    void Fadeout()
    {
        
        buttons[0].transform.GetComponent<CanvasGroup>().DOFade(1, 1.3f);
        buttons[1].transform.GetComponent<CanvasGroup>().DOFade(1, 1.3f);
        buttons[2].transform.GetComponent<CanvasGroup>().DOFade(1, 1.3f);
        buttons[3].transform.GetComponent<CanvasGroup>().DOFade(1, 1.3f);
        buttons[4].transform.GetComponent<CanvasGroup>().DOFade(1, 1.3f);
    }
    public void LinksManager(string url)
    {
        Application.OpenURL(url);
    }
    public void DetailBtn()
    {
        buttons[5].SetActive(true);
        buttons[5].transform.GetComponent<CanvasGroup>().DOFade(1, 1f);
        buttons[6].SetActive(false);
    }
    public void BackBtn()
    {
        SceneManager.LoadScene(0);
    }


}
