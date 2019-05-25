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
		if (message[0] == '+') 
		{
			Debug.Log("Keycube: " + message.Substring(1));
			GameObject key = transform.Find("Matrix/" + message[1] + "/" + message.Substring(1)).gameObject;
			if (key != null)
			{
				key.SetActive(!key.activeSelf);
			}				
		}
	}
}
