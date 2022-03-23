using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class DisplayVRGoggles : MonoBehaviour
{
    
	
	public	bool veri;
	
	public GameObject simScene;
	public GameObject selectScene;
	public GameObject gogglesScene;
	
	public AudioSource countdownSound;
	//public int getSoin = 0;
	
	//public Text finalScore;
	
	public float timeLeft = 15f;
	public Text timerText;
	//public float vrCoeffish;
	// Start is called before the first frame update
    void Start(){

		timeLeft = 15f;
		veri = false;
		//GetComponent<GoToSimulation>().coefficient = vrCoeffish;
		
}

    // Update is called once per frame
    void Update()
    {
	   
	   timerFunction();
	   
	   
	   
	
    }
	
	
	
	
	
	
	
//////////////////////////////////////////////////////////////////
	
	
////////////////////////////////////////////////////////////////////////
public void timerFunction(){
	
	
	
	timeLeft= timeLeft - Time.deltaTime;
	
	int seconds = (int)(timeLeft% 60);
	int minutes = (int)(timeLeft/ 60)%60;
	int hours = (int)(timeLeft/3600)% 24;

	//string strTime = string.Format("{0:0}:{1:00}:{2:00},hours,minutes,seconds");

	string strTime = seconds.ToString();
			
	timerText.text= strTime;
	
	if(timeLeft > 5 && timeLeft > 6)
	{ 
		//Play Beeping Sound
		countdownSound.Play();
		
		
	}
	
	
	
	if(timeLeft > 7)
	{ 
		//Play Beeping Sound
		countdownSound.Pause();
		
		
	}
	
	
	if(timeLeft < 1)
	{ 
		//Play Beeping Sound
		countdownSound.Pause();
		
		
	}
	
	

	if(seconds <0)
	{ 
		//scoScene.SetActive(true);
		//queScene.SetActive(false);
		//questionNum=1;
		//finalScore.text=scoreCount.ToString();
		veri = true;
		simScene.SetActive(true);
		selectScene.SetActive(false);
		gogglesScene.SetActive(false);
	}
	
	
	
	
	
	
}

public void playSounds(){

}
}
