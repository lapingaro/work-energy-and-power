using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timeLeft = 30.00F;
	public float carTimeLeft = 0.00F;
	public CarEngine cr;
	public CollisionScript cs;
	public GoToSimulation gtsCheck;
	public Text collideds;
	public Text result;
	public Text txtAnswer;
	//public Text answer;
	// Use this for initialization
	void Start () {
		collideds.text = "COEFFECIENT IS : ";
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		
		carTimeLeft+= Time.deltaTime;
		
		
		//GetComponent<CarEngine>().carTimer = carTimeLeft;
		//cr.carTimer = carTimeLeft;
		
		/*if ( timeLeft < 0 )
		{
			cr.resetVaules();
			collideds.text = "";
			txtAnswer.text = "";
			result.text = "";
		}*/


		if ( timeLeft < 0 && cr.carCondition == false )
		{
			cr.resetVaules();
			collideds.text = "";
			txtAnswer.text = "";
			result.text = "Car Did Not Make It To The Finish Point";
		}
		
		
		if ( timeLeft < 0 && cr.carCondition == true )
		{

			cr.resetVaules();
		}
		
		if ( cr.carCondition == false )
		{

			GetComponent<GoToSimulation>().calcTime = carTimeLeft;
			gtsCheck.calcTime = carTimeLeft;
			
			
			
			
			
		}
		


	}
		

		
}
