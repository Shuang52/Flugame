using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour {

	private bool narration_continue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public bool narrationContinue{
		get{ return narration_continue; }
		set{ narration_continue = value; }
	}
}
