using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gvrSimButtons : MonoBehaviour
{
	
	public Image imgButton;
	public UnityEvent GVRClicker;
	public float totalTime = 4;
	bool gvrStatus;
	public float gvrTimer;
	


    // Update is called once per frame
    void Update()
    {
        if(gvrStatus == true)
		{
			gvrTimer += Time.deltaTime;
			//imgButton.fillAmount = gvrTimer/totalTime;
		}
		
		
		if(gvrTimer > totalTime)
		{
			GVRClicker.Invoke();
			
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
	}
	
}
