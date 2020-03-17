using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	Renderer[] rn;

	// Use this for initialization
	void Start () {
		rn = gameObject.GetComponentsInChildren<Renderer>();
	}

	public void Red()
	{
		rn [0].material.color = Color.red;
	}

	public void Bule()
	{
		rn [0].material.color = Color.blue;
	}

	public void Green()
	{
		rn [0].material.color = Color.green;
	}

	public void Yellow()
	{
		rn [0].material.color = Color.yellow;
	}

	public void Purple()
	{
		rn [0].material.color = Color.magenta;
	}

	public void Black()
	{
		rn [0].material.color = Color.black;
	}
}
