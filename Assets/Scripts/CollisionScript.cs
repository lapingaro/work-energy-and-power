using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour {
	
	public GameObject objCollided;
	public Text collided;
	public bool condition = false;
	public float coeffish;
	public float chkCoefficient;
	

	// Use this for initialization
	void Start () {
		
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		//string coefficient;
		//chkCoefficient = objCollided.coefficient;
		//GetComponent<GoToSimulation>().coefficient = coeffish;
		GetComponent<CarEngine>().carCoefficient = coeffish;
		
		
		if(other.tag == "Collided")
		{
			
			//GetComponent<GoToSimulation>().calcCoEfficient();
			//coeffish = 100;
			collided.text =  coeffish.ToString();
			condition = true;
		}

	}
	
	
	public void setCieffiscient()
	{
		
		GetComponent<GoToSimulation>().coefficient = coeffish;
	}
}
