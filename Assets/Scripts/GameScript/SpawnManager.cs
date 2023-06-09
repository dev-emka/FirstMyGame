using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pota;
    public float xdefault, yMin, yMax;
    public PlayerController playerCs;

    private void Awake()
    {
        StartCoroutine(spawnet());
    }
    

    public IEnumerator spawnet()
    {
        while (playerCs.isfinal==false)
        {
            Instantiate(pota,new Vector3(xdefault,Random.Range(yMin,yMax),0) , Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
    }
   
}
