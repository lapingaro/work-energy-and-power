using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class back2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeactivatorVR("none"));
    }

   public IEnumerator DeactivatorVR(string NOVR){


   	UnityEngine.XR.XRSettings.LoadDeviceByName(NOVR);
   	yield return null;
   	UnityEngine.XR.XRSettings.enabled=false;
   }
}
