using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	Text text;
	private float score=0;
	const string scoreprefix="Score:";
	public float point;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		text.text = scoreprefix + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddScore(){
		score += point;
		text.text = scoreprefix + score;
	}
}
