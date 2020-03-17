using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	public void LightOn()
	{
		gameObject.SetActive (true);
	}

	public void LightOff()
	{
		gameObject.SetActive (false);
	}
}
