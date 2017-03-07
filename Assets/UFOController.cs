using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {
	public float speed;
	public float forcevalue;
	Rigidbody2D rigidbody2D=null;
	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 force = Vector2.zero;
		if (Input.GetKey (KeyCode.W)) {
			force.y += forcevalue;
//			transform.position += new Vector3 (0, speed*Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			force.y -= forcevalue;
//			transform.position -= new Vector3 (0, speed*Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			force.x -= forcevalue;
//			transform.position -= new Vector3 (speed*Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			force.x += forcevalue;
//			transform.position += new Vector3 (speed*Time.deltaTime, 0, 0);
		}
		rigidbody2D.AddForce (force);
		
	}
}
