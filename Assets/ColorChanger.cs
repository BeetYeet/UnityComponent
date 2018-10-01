using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

	public SpriteRenderer sr;
	public float changeTime = 10;

	void Start () {
		
	}
	
	void Update () {
		sr.color = new Color(.5f, Mathf.Sin(Time.time/changeTime), .5f);
	}
}
