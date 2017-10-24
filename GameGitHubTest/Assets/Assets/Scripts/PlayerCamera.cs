using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Vector3 offset;
	public Transform target;
	public bool UseOffSetValues;
	public float rotationSpeed;



	// Use this for initialization
	void Start () {
		if (!UseOffSetValues) 
		{
			offset = target.position - transform.position;
		}

	}
	
	// Update is called once per frame
	void Update () {

		// Get X position of the mouse and rotate the target
		float horizontal = Input.GetAxis("Mouse Y") * rotationSpeed;
		target.Rotate (0, horizontal, 0);



		
	}
}
