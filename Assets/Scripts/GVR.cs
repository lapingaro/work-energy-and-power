using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVR : MonoBehaviour
{
    public Image circle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;



    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            circle.fillAmount = gvrTimer / totalTime;
            //Debug.Log("Yes");
        }

        if(gvrTimer > totalTime)
        {
            GVRClick.Invoke();
            gvrOff();
        }
    }

    public void gvrOn()
    {
        gvrStatus = true;
    }

    public void gvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        circle.fillAmount = 0;
    }
}
