using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSimulation : MonoBehaviour
{
public float coefficient = 199F;	
 public float size;
public string driveType;
public int speed;

public int incline;
public bool addMass;
public int dTrain;


		public float calcGravity = 9.8F;
		public float calcMass;
		public float calcDistance = 2000F;
		public float calcTime;
		
		
		public float calcNetForce;
		public float calcAppliedForce;
		public float calcFrictionalForce;
		public float calcNormalForce;
/*
	public GameObject objSmokeFL;
	public GameObject objSmokeFR;
	public GameObject objSmokeRL;
	public GameObject objSmokeRR;
	
	public GameObject objAddedMass;
	
	public GameObject objInclines180;
	public GameObject objInclines30;
	public GameObject objInclines45;
	
	*/
	

	public bool checkIncline180 = false;
	public bool checkIncline30 = false;
	public bool checkIncline45 = false;
	
	public float maxMotorTorque;
	public float varMass;
	
	
	
	
	public void changeToQuestion()
    {
        SceneManager.LoadScene(6);
		

    }
	
	public void restartSimulation()
    {
        SceneManager.LoadScene(5);
		

    }


	
	public void changeToSimulation()
    {
        SceneManager.LoadScene(6);
		

    }
////////////////////////////////////////////////////////


    void Start()
    {
		coefficient = 0F;
		
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<CarEngine>().inclineGTS = incline;
		GetComponent<CarEngine>().torqueGTS = maxMotorTorque;
		GetComponent<CarEngine>().driveTrainGTS = dTrain;
		GetComponent<CarEngine>().addMassGTS = addMass;
		//GetComponent<CollisionScript>().coeffish = 99F;
		
		
		
		
		
    }
	
	public void parseValues(int parseIncline, bool parseAssMass, int parseDriveTrain, float parseTorque)
	{
		parseIncline = incline;
		parseAssMass = addMass;
		parseDriveTrain = dTrain;
		parseTorque = maxMotorTorque;
	}





public void sizeCatMin(){

size = 1000;
addMass = false;
GetComponent<CarEngine>().addMassGTS = addMass;
varMass = 1.0F;

calcMass = size;
}

public void sizeMax(){

size = 1450;
addMass = true;
GetComponent<CarEngine>().addMassGTS = addMass;
varMass = 0.75F;

calcMass = size;
}
//////////////////////////////////////////////////////////////
public void rwdType(){
driveType= "rear wheel drive";
dTrain =1;
GetComponent<CarEngine>().driveTrainGTS = dTrain;
}

public void fwdType(){
driveType= "front wheel drive";
dTrain =2;
GetComponent<CarEngine>().driveTrainGTS = dTrain;

}

public void fourwdType(){
driveType= "four wheel drive";
dTrain=3;
GetComponent<CarEngine>().driveTrainGTS = dTrain;

}
///////////////////////////////////////////////////













public void speedMin(){
speed = 50;

maxMotorTorque = speed * 0.5f * varMass;
GetComponent<CarEngine>().torqueGTS = maxMotorTorque;
//calcCoEfficient();
////////////////////////////////////////////////




//coefficient = 99F;

		//calcNetForce = (2F * calcMass * calcDistance)/(calcTime*calcTime);
		
		//calcAppliedForce = calcMass * calcGravity;
		
		//calcFrictionalForce = calcNetForce - calcAppliedForce;		
		
		//calcNormalForce = (calcMass * calcGravity) * Mathf.Cos(incline);
		
		//coefficient = calcFrictionalForce/calcNormalForce;

		//GetComponent<CollisionScript>().coeffish = coefficient;
		
		//GetComponent<DisplayVRGoggles>().vrCoeffish = coefficient;
		
		//GetComponent<CollisionScript>().coeffish = coefficient;
		
		//GetComponent<CarEngine>().carCoefficient = coefficient;

}

public void speedInt(){
speed = 100;

maxMotorTorque = speed * 0.75f * varMass;
GetComponent<CarEngine>().torqueGTS = maxMotorTorque;
//calcCoEfficient();
////////////////////////////////////////////////

		//coefficient = 99F;


		//calcNetForce = (2F * calcMass * calcDistance)/(calcTime*calcTime);
		
		//calcAppliedForce = calcMass * calcGravity;
		
		//calcFrictionalForce = calcNetForce - calcAppliedForce;		
		
		//calcNormalForce = (calcMass * calcGravity) * Mathf.Cos(incline);
		
		//coefficient = calcFrictionalForce/calcNormalForce;

		//GetComponent<CollisionScript>().coeffish = coefficient;
		
		//GetComponent<CarEngine>().carCoefficient = coefficient;
}

public void speedMax(){
speed = 150;

maxMotorTorque = speed * 0.95f * varMass;
GetComponent<CarEngine>().torqueGTS = maxMotorTorque;
//calcCoEfficient();
////////////////////////////////////////////////

//coefficient = 99F;

		//calcNetForce = (2F * calcMass * calcDistance)/(calcTime*calcTime);
		
		//calcAppliedForce = calcMass * calcGravity;
		
		//calcFrictionalForce = calcNetForce - calcAppliedForce;		
		
		//calcNormalForce = (calcMass * calcGravity) * Mathf.Cos(incline);
		
		//coefficient = calcFrictionalForce/calcNormalForce;

		//GetComponent<CollisionScript>().coeffish = coefficient;
		
		//GetComponent<CarEngine>().carCoefficient = coefficient;
}













///////////////////////////////////////////////////////
public void inclineMin(){
incline = 30;
GetComponent<CarEngine>().inclineGTS = incline;
}

public void inclineInt(){
incline = 45;
GetComponent<CarEngine>().inclineGTS = incline;
}

public void inclineMax(){
incline = 180;
GetComponent<CarEngine>().inclineGTS = incline;
}
///////////////////////////////////////////////////////

public float speedVari(){
	
	float s;
	s= speed;
	
	return maxMotorTorque;
}


public int inclineVari(){
	int i;
	i= incline;
	return incline;
	
}


public bool massVari(){

bool m;
m= addMass;

return addMass;
}	

public int driveVari(){
	
	int d;
	d=dTrain;
	
	return dTrain;
}


public float torqueVari(){
	
	float torque;
	torque=maxMotorTorque;
	
	return torque;
}


//////////////////////////////

	public void calcCoEfficient()
	{
		
		
		
		//calcNetForce = (2F * calcMass * calcDistance)/(calcTime*calcTime);
		
		//calcAppliedForce = calcMass * calcGravity;
		
		//calcFrictionalForce = calcNetForce - calcAppliedForce;		
		
		//calcNormalForce = (calcMass * calcGravity) * Mathf.Cos(incline);
		
		coefficient = 99F;
		
		//GetComponent<CollisionScript>().coeffish = coefficient;
		
		//GetComponent<CollisionScript>().coeffish = coefficient;
		//GetComponent<CollisionScript>().coeffish = coefficient;

	}
	
	






}
