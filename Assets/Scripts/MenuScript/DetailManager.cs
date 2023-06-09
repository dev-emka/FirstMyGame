using System.Collections;

using UnityEngine;
using UnityEngine.UI;


public class DetailManager : MonoBehaviour
{
    public float gecikme;
    
    

    [Multiline]
    public string yazim;

    public Text buText;
    private void Start()
    {
        
        
        StartCoroutine(Yazdir());
    }

    IEnumerator Yazdir()
    {
        foreach(char i in yazim)
        {
            buText.text += i.ToString();
            
           
            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(1f);
                
            }
            else
            {
                yield return new WaitForSeconds(gecikme);
            }
            

            

        }
    }
}
