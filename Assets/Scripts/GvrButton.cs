using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using UnityEngine.SceneManagement;

public class GvrButton : MonoBehaviour
{
   // public Image imgCircle;
    public UnityEvent GvrClick;
    public float totalTime = 2;
    bool gvrStatus,gvrDelayStatus;
    public float gvrTimer,gvrDelayTimer;
    float gvrDelay = 2;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(gvrDelayStatus==false)
        {
            gvrDelayTimer += Time.deltaTime;
        }
        if (gvrDelayTimer>gvrDelay)
        {
            gvrDelayStatus = true;
        }
        if (gvrStatus&&gvrDelayStatus)
        {
            gvrTimer += Time.deltaTime;
           // imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if (gvrTimer > totalTime)
        {
            gvrDelayTimer = 0;
            gvrTimer = 0;
            gvrDelayStatus = false;
            GvrClick.Invoke();
            
            
        }
    }
  
    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
       // imgCircle.fillAmount = 0;
    }
    	public void SceneLoader(int SceneIndex)
    {
        //Debug.Log("SCENE: " + SceneIndex);
        SceneManager.LoadScene(SceneIndex);
    }

    public void TerminateApp()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
