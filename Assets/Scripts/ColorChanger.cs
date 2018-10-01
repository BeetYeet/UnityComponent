using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

	public SpriteRenderer sr;
	public float changeTime = 10;
	float val1, val2, val3;

	void Start () {
		
	}
	
	void Update () {
		val1 = Mathf.Sin( Time.time / changeTime * 1.21541218f);
		val2 = Mathf.Sin( Time.time / changeTime );
		val3 = Mathf.Sin( Time.time / changeTime * 1.4866464664f );
		sr.color = new Color(val1, val2, val3 );
		this.transform.position = new Vector3(val1, val2, val3);
	}
}
