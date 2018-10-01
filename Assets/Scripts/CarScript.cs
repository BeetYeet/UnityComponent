using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

	public float rotateSpeed = 1f;
	public float driveSpeed = 1f;

	void Start () {
		
	}
	
	void Update ()
	{
		if ( Input.GetKey( KeyCode.LeftArrow ) )
		{
			transform.Rotate( new Vector3( 0f, 0f, 1f ), rotateSpeed * 90 * Time.deltaTime );
		}
		if ( Input.GetKey( KeyCode.RightArrow ) )
		{
			transform.Rotate( new Vector3( 0f, 0f, 1f ), rotateSpeed * -90 * Time.deltaTime );
		}
		if ( Input.GetKey( KeyCode.UpArrow ) )
		{
			transform.Translate( 0f, driveSpeed * 1f * Time.deltaTime, 0f, Space.Self );
		}
		if ( Input.GetKey( KeyCode.DownArrow ) )
		{
			transform.Translate( 0f, driveSpeed * -0.3f * Time.deltaTime, 0f, Space.Self );
		}

	}
}
