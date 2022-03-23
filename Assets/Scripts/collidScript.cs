using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidScript : MonoBehaviour
{

    //public Renderer cube;
    public static bool colliedOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            cubeHit();

        }
    }

    public void cubeHit()
    {

        colliedOn = true;
    }
}
