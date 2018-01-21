using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour {

	private bool narration_continue;

	// Use this for initialization
	void Start () {
		narration_continue = true;
		GameObject.Find ("Narration").GetComponent<NarrationScript> ().StartNarration ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrController.ClickButtonDown) {
			GameObject.Find ("Narration").GetComponent<NarrationScript> ().GetNextNarration ();
		}
	}
		
	public bool narrationContinue{
		get{ return narration_continue; }
		set{ narration_continue = value; }
	}
}
