using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class SwitchToNormalMode : MonoBehaviour
{
	public void Start()
	{
		StartCoroutine(deactivatorVR("none"));
	}
	public IEnumerator deactivatorVR(string NOVR)
	{
		UnityEngine.XR.XRSettings.LoadDeviceByName(NOVR);
		yield return null;
		UnityEngine.XR.XRSettings.enabled = false;
	}
}
