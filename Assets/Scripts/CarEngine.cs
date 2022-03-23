using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;


public class CarEngine : MonoBehaviour {

    public Transform path;
    public float maxSteerAngle = 45f;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
	public WheelCollider wheelRL;
	public WheelCollider wheelRR;
	

	
    public float currentSpeed;
    public float maxSpeed = 1500f;
    public Vector3 centerOfMass;
	public Rigidbody rb;
	public Vector3 originalPos;
	public Vector3 wheelOGPos;
	public bool test = true;
	
	public GameObject Simmer;
	
	
	//////////////////////////////////////////////////////////////////////////
	
	//
   // public float maxMotorTorqueStat;
	//
	//public GameObject objSmokeFLStat;
	//public GameObject objSmokeFRStat;
	//public GameObject objSmokeRLStat;
	//public GameObject objSmokeRRStat;
	//
	//public GameObject objAddedMassStat;
	///
	//public GameObject objInclines180Stat;
	//public GameObject objInclines30Stat;
	//public GameObject objInclines45Stat;
	//
	
	
	//
	public bool checkIncline180Stat;
	public bool checkIncline30Stat;
	public bool checkIncline45Stat;
	
	
	
	
	
		public float carTimeLeft = 0.00F;
		public float carCalcGravity = 9.8F;
		public float carCalcMass;
		public float carCalcDistance = 2000F;
		public float carCalcTime;
		
		
		public float carCalcNetForce;
		public float carCalcAppliedForce;
		public float carCalcFrictionalForce;
		public float carCalcNormalForce;
	
		public float carCoefficient;
		public int carIncline;
		
		
	
	
	
	
	
	
	
	//////////////////////////////////////////////////////////////////////////
	
	
	public GoToSimulation goToSim;
	
	
	public GameObject objInclines180;
	public GameObject objInclines30;
	public GameObject objInclines45;
	
	public GameObject objSmokeFL;
	public GameObject objSmokeFR;
	public GameObject objSmokeRL;
	public GameObject objSmokeRR;
	
	public GameObject objAddedMass;
	
	public Text carCollided;
	public float carGTSCoefficient;
	public bool carCondition = false;
	
	
	
	public int inclineGTS;
	public bool addMassGTS;
	public int driveTrainGTS;
	public float speedGTS;
	public float torqueGTS;
	public string txtInc;
	
	public bool doubleCheck = true;
	

	public float fltMass;

    private List<Transform> nodes;

    private int currectNode = 0;
    
	
	public bool checkThis = true;
	
	
	public void Start () {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
		
		//inclineGTS = GetComponent<GoToSimulation>().incline;
		//torqueGTS = GetComponent<GoToSimulation>().maxMotorTorque;
		//driveTrainGTS = GetComponent<GoToSimulation>().dTrain;
		//addMassGTS = GetComponent<GoToSimulation>().addMass;
		

        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++) {
            if (pathTransforms[i] != path.transform) {
                nodes.Add(pathTransforms[i]);
            }
        }

		originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		//wheelOGPos = new Vector3(wheelFR.transform.position.x, wheelFR.transform.position.y, wheelFR.transform.position.z);

		//originalPos = gameObject.transform.position;

		//checkIncline180 = true;
		//objInclines180.SetActive (true);
		//objInclines30.SetActive (false);
		//objInclines45.SetActive(false);
		//objAddedMass.SetActive (false);
		//fltMass = 1f;
		
		//inclineGTS = goToSim.incline;
		//addMassGTS = goToSim.addMass;
		//driveTrainGTS = goToSim.dTrain;
		//speedGTS = goToSim.speedVari();
		//torqueGTS = goToSim.maxMotorTorque;
		
		//GetComponent<GoToSimulation>().parseValues(inclineGTS,addMassGTS,driveTrainGTS,driveTrainGTS);
		
		//maxMotorTorqueStat = goToSim.maxMotorTorque
		
		//inclineGTS = GetComponent<GoToSimulation>().inclineVari();
		//addMassGTS = GetComponent<GoToSimulation>().massVari();
		//driveTrainGTS = GetComponent<GoToSimulation>().driveVari();
		//speedGTS = GetComponent<GoToSimulation>().speedVari();
		//torqueGTS = GetComponent<GoToSimulation>().torqueVari();
		
    }
	
	public void FixedUpdate () {
		
		carTimeLeft+= Time.deltaTime;
		
		
		
		if(doubleCheck == false){
			resetVaules();
			
		}
		
		
		
		if(carTimeLeft > 4 && checkThis == true){
        ApplySteer();
        CheckWaypointDistance();
		Drive();
		InclinesChange180();
		AddMass();
		driveTrainCheck();
		
		
		}else{
			
			objSmokeFL.SetActive (false);
			objSmokeFR.SetActive (false);
			objSmokeRL.SetActive (false);
			objSmokeRR.SetActive (false);
			InclinesChange180();
		AddMass();
		}
		
		if (carCondition == true )
		{

			carCoefficient = carCalcFrictionalForce/carCalcNormalForce;

			
		
			
			//gtsCheck.calcTime = carTimeLeft;
		}
		
		
		if(carCondition == false && checkThis == true)
		{
			GetComponent<GoToSimulation>().calcTime = carTimeLeft-4;
			carCalcMass = GetComponent<GoToSimulation>().calcMass;
			carIncline = GetComponent<GoToSimulation>().incline;
			
			
			carCalcNetForce = (2F * carCalcMass * carCalcDistance)/(carTimeLeft*carTimeLeft);
		
			carCalcAppliedForce = carCalcMass * carCalcGravity;
		
			carCalcFrictionalForce = carCalcNetForce - carCalcAppliedForce;		
		
			carCalcNormalForce = (carCalcMass * carCalcGravity) * Mathf.Cos(carIncline);
		
			
			
		}
		
		
	}
	
	public void OnTriggerEnter(Collider other)
	{
		//string coefficient;
		//chkCoefficient = objCollided.coefficient;
		//GetComponent<GoToSimulation>().coefficient = coeffish;
		//GetComponent<CarEngine>().carCoefficient = coeffish;
		//carCoefficient = 10;
		
		if(other.tag == "Collided")
		{
			
			//GetComponent<GoToSimulation>().calcCoEfficient();
			//coeffish = 100;
			carCollided.text =  carCoefficient.ToString() + " N";
			carCondition = true;
			//resetVaules();
		}


		if(other.tag == "Collided2")
		{
			
			doubleCheck = false;
			resetVaules();
		}
	}
	
	

	public void ApplySteer() {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currectNode].position);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;
    }

	public void Drive() {
        currentSpeed = 9 * Mathf.PI * wheelRL.radius * wheelRL.rpm * 15 / 100;
		//currentSpeed = 8 * Mathf.PI * wheelRL.radius * wheelRL.rpm * 10 / 100;

        if (currentSpeed < maxSpeed) {
            //wheelFL.motorTorque = maxMotorTorque;
            //wheelFR.motorTorque = maxMotorTorque;
			//wheelRL.motorTorque = maxMotorTorque;
			//wheelRR.motorTorque = maxMotorTorque;
			
			
			wheelFL.motorTorque = torqueGTS;
            wheelFR.motorTorque = torqueGTS;
			wheelRL.motorTorque = torqueGTS;
			wheelRR.motorTorque = torqueGTS;
			
			
			
			
        } else {
            wheelFL.motorTorque = 0;
            wheelFR.motorTorque = 0;
			wheelRL.motorTorque = 0;
			wheelRR.motorTorque = 0;
        }





    }

	public void CheckWaypointDistance() {
        if(Vector3.Distance(transform.position, nodes[currectNode].position) < 0.5f) {
            if(currectNode == nodes.Count - 1) {
                currectNode = 0;
            } else {
                currectNode++;
            }
        }
    }


	public void resetVaules(){
		test = false;
		gameObject.transform.position = originalPos;
		//wheelFR.transform.position = wheelOGPos;
		torqueGTS = 0;
		objSmokeFL.SetActive (false);
			objSmokeFR.SetActive (false);
			objSmokeRL.SetActive (false);
			objSmokeRR.SetActive (false);
			 nodes[currectNode].position = originalPos;
			currentSpeed=0;
			checkThis = false;
			
			wheelFL.motorTorque = 0;
            wheelFR.motorTorque = 0;
			wheelRL.motorTorque = 0;
			wheelRR.motorTorque = 0;
			
			wheelFL.steerAngle = 0;
        wheelFR.steerAngle = 0;
	}
	

	


	public void InclinesChange180(){
		
		
		if(inclineGTS == 180){
			objInclines180.SetActive (true);
			objInclines30.SetActive (false);
			objInclines45.SetActive (false);
			carCalcDistance = 600;
		}
		
		if(inclineGTS == 30){
			objInclines30.SetActive (true);
			objInclines180.SetActive (false);
			objInclines45.SetActive (false);
			carCalcDistance = 920;
			
		}
		
		if(inclineGTS == 45){
			objInclines45.SetActive (true);
			objInclines180.SetActive (false);
			objInclines30.SetActive (false);
			carCalcDistance = 1150;
		}




	}
	
	
	public void driveTrainCheck(){
		
		if(currentSpeed < 0){
		if(driveTrainGTS == 3){
			objSmokeFL.SetActive (true);
			objSmokeFR.SetActive (true);
			objSmokeRL.SetActive (true);
			objSmokeRR.SetActive (true);
			
			
		}
		}

		if(currentSpeed < 0){
		if(driveTrainGTS == 2){
			objSmokeFL.SetActive (true);
			objSmokeFR.SetActive (true);
			objSmokeRL.SetActive (false);
			objSmokeRR.SetActive (false);
			
		}
		}
		
		if(currentSpeed < 0){
		if(driveTrainGTS == 1){

			objSmokeFL.SetActive (false);
			objSmokeFR.SetActive (false);
			objSmokeRL.SetActive (true);
			objSmokeRR.SetActive (true);

		}
		}
	}
	
	
	public void AddMass(){
		if(addMassGTS == true)
		{
			objAddedMass.SetActive (true);
			//fltMass = 1.5f;
		}else{
			objAddedMass.SetActive (false);
			//fltMass = 0.5f;
		}
	}
	
	
	/*
	public void assignerBtn(){

		//maxMotorTorque = 30 * fltMass;

		if(objAddedMass.active == true)
		{

			maxMotorTorque = speedGTS * 0.5f;

		}else{

			maxMotorTorque = speedGTS;
		}

	}



	public void AddMass(){
		if(addMassGTS == true)
		{
			objAddedMass.SetActive (true);
			//fltMass = 1.5f;
		}else{
			objAddedMass.SetActive (false);
			//fltMass = 0.5f;
		}
	}

	
	
	
	public void driveTrainCheck(){
		
		
		if(driveTrainGTS == 1){
			objSmokeFL.SetActive (false);
			objSmokeFR.SetActive (false);
			objSmokeRL.SetActive (true);
			objSmokeRR.SetActive (true);
			
			
		}else if(inclineGTS == 2){
			objSmokeFL.SetActive (true);
			objSmokeFR.SetActive (true);
			objSmokeRL.SetActive (false);
			objSmokeRR.SetActive (false);
			
		}else{
			objSmokeFL.SetActive (true);
			objSmokeFR.SetActive (true);
			objSmokeRL.SetActive (true);
			objSmokeRR.SetActive (true);
		}

	}
	
	*/


}