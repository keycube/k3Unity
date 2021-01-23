using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycube : MonoBehaviour {

	public ReadSerial readSerial;

	private Vector3 ypr = Vector3.zero;
	private Vector3 yaw = Vector3.zero;
	private Vector3 pitch = Vector3.zero;
	private Vector3 roll = Vector3.zero;
	private Quaternion quat = new Quaternion();
	private Quaternion lastQuat = new Quaternion();
	private Quaternion diffQuat = new Quaternion();

	private float offset = 0f;

	private float speedFactor = 15.0f;

	// Use this for initialization
	void Start () 
	{
		if (readSerial != null) 
		{
			readSerial.OnRead += ReadSerial_OnRead;
		}
	}

	void Update() {
		if (Input.GetKeyDown("space"))
        {
			offset = transform.eulerAngles.y;
			Debug.Log("SPACE > " + offset);
        }
	}
	
	private void ReadSerial_OnRead(string message)
	{
		string[] quatStr = message.Split(',');
		if (quatStr.Length > 3) {
			// QUATERNION

		//quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[2]), float.Parse(quatStr[1]), float.Parse(quatStr[0])); 
				//quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[2]), float.Parse(quatStr[0]), float.Parse(quatStr[1]));
		//quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[1]), float.Parse(quatStr[2]), float.Parse(quatStr[0]));
				//quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[1]), float.Parse(quatStr[0]), float.Parse(quatStr[2]));
			// quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[0]), float.Parse(quatStr[1]), float.Parse(quatStr[2]));
			// quat.Set(float.Parse(quatStr[3]), float.Parse(quatStr[0]), float.Parse(quatStr[2]), float.Parse(quatStr[1]));

			//quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[3]), float.Parse(quatStr[1]), float.Parse(quatStr[0]));
			// quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[3]), float.Parse(quatStr[0]), float.Parse(quatStr[1]));
			//quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[1]), float.Parse(quatStr[3]), float.Parse(quatStr[0]));
			// quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[1]), float.Parse(quatStr[0]), float.Parse(quatStr[3]));
			// quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[0]), float.Parse(quatStr[1]), float.Parse(quatStr[3]));
			// quat.Set(float.Parse(quatStr[2]), float.Parse(quatStr[0]), float.Parse(quatStr[3]), float.Parse(quatStr[1]));

			//quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[2]), float.Parse(quatStr[3]), float.Parse(quatStr[0]));
			// quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[2]), float.Parse(quatStr[0]), float.Parse(quatStr[3]));
			//quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[3]), float.Parse(quatStr[2]), float.Parse(quatStr[0]));
			// quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[3]), float.Parse(quatStr[0]), float.Parse(quatStr[2]));
			// quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[0]), float.Parse(quatStr[3]), float.Parse(quatStr[2]));
			// quat.Set(float.Parse(quatStr[1]), float.Parse(quatStr[0]), float.Parse(quatStr[2]), float.Parse(quatStr[3]));

		//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[2]), float.Parse(quatStr[1]), float.Parse(quatStr[3]));
			//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[2]), float.Parse(quatStr[3]), float.Parse(quatStr[1]));
		//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[1]), float.Parse(quatStr[2]), float.Parse(quatStr[3]));
			//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[1]), float.Parse(quatStr[3]), float.Parse(quatStr[2]));
			//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[3]), float.Parse(quatStr[1]), float.Parse(quatStr[2]));
			//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[3]), float.Parse(quatStr[2]), float.Parse(quatStr[1]));


			//transform.rotation = quat;
			//quat.Set(float.Parse(quatStr[0]), float.Parse(quatStr[2]), float.Parse(quatStr[1]), float.Parse(quatStr[3]));
			

            /*
			float w = float.Parse(quatStr[0]);
            float x = float.Parse(quatStr[1]);
            float y = float.Parse(quatStr[3]);
            float z = float.Parse(quatStr[2]);
            transform.localRotation = Quaternion.Lerp(this.transform.localRotation,  new Quaternion(w, y, x, z), Time.deltaTime * speedFactor);
			*/
        
			//transform.localRotation = quat;

        	//this.transform.parent.transform.eulerAngles = rotationOffset;

			//diffQuat = Quaternion.Inverse(quat) * lastQuat ;
         	//transform.Rotate(diffQuat.eulerAngles, Space.World);
         	//lastQuat = quat;

			//quat.Set(0, 0, 0, 1f);
			//transform.rotation = quat;
			//transform.rotation = Quaternion.Inverse(quat);


			// WORKING FOR MPU6050 & KINDA FOR 9250
			
			float w = float.Parse(quatStr[0]);
            float x = float.Parse(quatStr[1]);
            float y = float.Parse(quatStr[2]);
            float z = float.Parse(quatStr[3]);
            transform.localRotation = Quaternion.Lerp(transform.localRotation,  new Quaternion(w, y, x, z), Time.deltaTime * speedFactor);
			
			/*
			float w = float.Parse(quatStr[0]);
            float x = float.Parse(quatStr[1]);
            float y = float.Parse(quatStr[2]);
            float z = float.Parse(quatStr[3]);
            transform.localRotation = Quaternion.Lerp(transform.localRotation,  new Quaternion(0f, y, x, z), Time.deltaTime * speedFactor);
			*/
			
			// YAW PITCH ROLL			
			//ypr.Set(float.Parse(quatStr[2]), 0, 0);
			//ypr.Set(0, 0, float.Parse(quatStr[1]));
			//ypr.Set(0, float.Parse(quatStr[0])-offset, 0);
			
			//ypr.Set(float.Parse(quatStr[2]), 0, float.Parse(quatStr[1]));

			//ypr.Set(float.Parse(quatStr[0])-offset, float.Parse(quatStr[1]), float.Parse(quatStr[2]));

			// In this coordinate system, the positive z-axis is down toward Earth.
      		// Yaw is the angle between Sensor x-axis and Earth magnetic North (or true North if corrected for local declination, looking down on the sensor positive yaw is counterclockwise.
      		// Pitch is angle between sensor x-axis and Earth ground plane, toward the Earth is positive, up toward the sky is negative.
      		// Roll is angle between sensor y-axis and Earth ground plane, y-axis up is positive roll.
      		// These arise from the definition of the homogeneous rotation matrix constructed from quaternions.
      		// Tait-Bryan angles as well as Euler angles are non-commutative; that is, the get the correct orientation the rotations must be
      		// applied in the correct order which for this configuration is yaw, pitch, and then roll.
      		// For more see http://en.wikipedia.org/wiki/Conversion_between_quaternions_and_Euler_angles which has additional links.

			//ypr.Set(-float.Parse(quatStr[2]), 0, -float.Parse(quatStr[1]));
			//ypr.Set(float.Parse(quatStr[2]), float.Parse(quatStr[0])-offset, -float.Parse(quatStr[1]));
			//transform.localEulerAngles = ypr;
			//pitch.Set(-float.Parse(quatStr[2]), 0, 0);
			//aX.transform.localEulerAngles = pitch;

			//roll.Set(0, 0, -float.Parse(quatStr[1]));
			//aZ.transform.localEulerAngles = roll;

		
			//ypr.Set(transform.eulerAngles.x, -transform.eulerAngles.y * 180/Mathf.PI, -transform.eulerAngles.z * 180/Mathf.PI);
			//transform.eulerAngles = ypr;
			
			/*
			float yaw = float.Parse(quatStr[0]);
            float pitch = float.Parse(quatStr[1]);
            float roll = float.Parse(quatStr[2]);
			ypr.Set(pitch, yaw, -roll);
			transform.localEulerAngles = ypr;
			*/
			//transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, new Vector3(yaw, pitch, roll), Time.deltaTime * speedFactor);
		}
		/* 
		switch(message[0])
		{
			// Read keys event
			case '+':
			{
				GameObject key = transform.Find("Matrix/" + message[1] + "/" + message.Substring(1)).gameObject;
				if (key != null)
				{
					key.SetActive(!key.activeSelf);
				}				
			}
			break;

			// Read inertial values
			case '*':
			{
				// TODO
				// ...
				// message.Split(':')
				// float.Parse(...)
				// ...
			}
			break;
		}
		*/
	}
}