using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycube : MonoBehaviour {

	public ReadSerial readSerial;

	// Use this for initialization
	void Start () 
	{
		if (readSerial != null) 
		{
			readSerial.OnRead += ReadSerial_OnRead;
		}
	}
	
	
	private void ReadSerial_OnRead(string message)
	{
		Debug.Log("Keycube: " + message);
	}
}
