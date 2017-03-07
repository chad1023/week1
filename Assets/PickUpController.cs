using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour {
	public ScoreManager scoremanager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3 (0, 45, 0);
		
	}
	void OnTriggerEnter2D(Collider2D other){
		scoremanager.AddScore ();
		gameObject.SetActive (false);
	
	}
}
