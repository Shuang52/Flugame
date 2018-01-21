using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrationScript : MonoBehaviour {

	public TextAsset document;
	string[] narration;
	int counter;

	// Use this for initialization
	void Start () {
		
	}

	public void StartNarration(){
		narration = document.text.Split ('\n');
		GetNextNarration ();
	}

	public void GetNextNarration(){
		if (counter < narration.Length) {
			GetComponent<TextMesh> ().text = narration [counter];
			counter++;
		} else {
			GameObject.Find ("SceneControl").GetComponent<SceneControl> ().narrationContinue = false;
		}
	}

}