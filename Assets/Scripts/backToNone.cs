using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class backToNone : MonoBehaviour
{
      // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(deactivatorVR("none"));
    }
	public IEnumerator deactivatorVR(string NOVR){
		XRSettings.LoadDeviceByName(NOVR);
		yield return null;
		XRSettings.enabled = false;
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
