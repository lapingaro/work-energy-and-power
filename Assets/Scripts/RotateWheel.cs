using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{


    public float torque=200f;
    protected Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
      
    }

   void FixedUpdate()
    {
        r.AddTorque(-transform.up * torque);
        torque += -0.05f;
        if (torque <= 0)
        {

            r.freezeRotation = true;
            torque = 0;
        }

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
