using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(InputManager))]
public class driving_script : MonoBehaviour
{

    public InputManager im;
    public List<WheelCollider> threttleWheels;
    public List<GameObject> steeringWheels;
    public List<GameObject> meshes;
    public float strenghtCoefficient = 20000f;
    public GameObject incline;
    float speed =10f;
    private Vector3 _rotation;
    public float maxTurn = 20f;
    public Rigidbody rb;






    private void Start()
    {
        im = GetComponent<InputManager>();
    }
    public void carAccelaration()

    {

        
        foreach (WheelCollider wheel in threttleWheels)
        {

            wheel.motorTorque = strenghtCoefficient * Time.deltaTime;
        }

      

        foreach(GameObject mesh in meshes)
        {

            mesh.transform.Rotate(-2f,0f,0f);
        }

    }
    // incline function
    public void inclineAngle()
    {

        // Rotate the incline
        
        
       incline.transform.Rotate(5, 0 ,0) ;

        
    }
    // Update is called once per frame
    void Update()
    {
        carAccelaration();
    }
}
