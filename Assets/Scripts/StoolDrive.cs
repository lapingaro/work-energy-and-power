using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HingeJoint))]
public class StoolDrive : MonoBehaviour
{

    HingeJoint joint;
    public float speed = 80;
    public float appliedForce = 1500f;
    public float distance = 50;
    public float angle = 0;

    public float workMaxVal;
    public float workDisplay;
    public Text worktext;
    public JointMotor motor;
    public Rigidbody spoolRb;
    public Rigidbody carWheels;
    public bool startOn;
    public List<GameObject> meshes;
    public Text appliedForceText;
    public float count=0;
    public Animator   colliderAnim;
    public Rigidbody pulleyRb;



    // Use this for initialization
    void Start()
    {
        joint = GetComponent<HingeJoint>();
        motor.targetVelocity = speed;
        appliedForce = motor.force;
      
        motor = joint.motor;
       

        angle = 0;




    }

    //increase the count value
    public void aplliedForceIncr()
    {

        count += 1;
        if (count >= 3)
        {

            count = 3;
        }

        
    }

    //decrease the count value
    public void aplliedForceDecr()
    {

        count += -1;
        if (count <= 0)
        {

            count = 0;
        }
       

    }

    public void checkAplliedForceVal()
    {

        if (count == 0)
        {
            appliedForceText.text = "0";

        }
        if (count == 1)
        {

            appliedForceText.text = "1500";
        }
        else if (count == 2)
        {
            appliedForceText.text = "2000";

        }
    }

    //Rotate wheels
    public void wheelRotate() {

        foreach (GameObject mesh in meshes)
        {

            mesh.transform.Rotate(-2f, 0f, 0f);
        }

    }

    //Stop wheels
    public void wheelStop()
    {

        foreach (GameObject mesh in meshes)
        {

            mesh.transform.Rotate(0f, 0f, 0f);
        }

    }

    // speed setting
    public void setSpeed()
    {

        // check the speed value
        if (appliedForceText.text == "1500")
        {
            // set the speed
            speed = 300;

           

        }
        else if (appliedForceText.text == "2000")
        {

            // set the speed
            speed = 600;

            // set the collider location
            colliderAnim.Play("back_collied");

           
        }
    }
    public void accelerateDrive()
    {

        

        if (collidScript.colliedOn)
        {
            
          spoolRb.constraints = RigidbodyConstraints.FreezeRotation;
           pulleyRb.constraints = RigidbodyConstraints.FreezeAll;


            //speed = 0;
            motor = joint.motor;
            motor.targetVelocity = speed;
            


            //calculate work 
            workDisplay = float.Parse(appliedForceText.text) * distance * Mathf.Cos(angle) ;
            worktext.text = workDisplay.ToString();
            // Debug.Log(workDisplay);


            //wheelRotate();



        }
        else
        {

            if (appliedForceText.text=="0")
            {
                workDisplay = float.Parse(appliedForceText.text) * distance * Mathf.Cos(angle);
                worktext.text = workDisplay.ToString();

            }
            // set up the speed
            //speed = 400f;
            motor = joint.motor;
            motor.targetVelocity = speed;
            //appliedForce = 1500f;
            // set motor force
            motor.force =float.Parse(appliedForceText.text);
            appliedForce =1500f;
            distance = 50f;
            angle = 0;
            workMaxVal = appliedForce * distance * Mathf.Cos(angle);


            // Rotate the wheels
            // Rotate the wheels

            wheelRotate();
        }


        joint.motor = motor;

      

    }

    public void startclicked()
    {

        startOn = true;
    }
 
    // Update is called once per frame
    void Update()
    {
       
       
        //verifi the value of the applied force
        checkAplliedForceVal();

        if (startOn)
        {

            setSpeed();
            accelerateDrive();
        }


        joint.motor = motor;

        
     



    }


    
    


}
