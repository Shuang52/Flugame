using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class BathroomChoice : MonoBehaviour {

	GameObject game_control, scene_control;
	public GameObject text;

	// Use this for initialization
	void Start () {
		game_control = GameObject.Find ("GameControl");
		scene_control = GameObject.Find ("SceneControl"); 

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerEnter(PointerEventData event_data){
		if(scene_control.GetComponent<SceneControl>().narrationContinue == false)
			text.SetActive (true);
	}

	public void OnPointerExit(PointerEventData event_data){
		if(scene_control.GetComponent<SceneControl>().narrationContinue == false)
			text.SetActive (true);
	}

	public void OnPointerClick(PointerEventData event_data){
		if (scene_control.GetComponent<SceneControl> ().narrationContinue == false) {		
			if (this.gameObject.name == "sink")
				WashedHands ();
			else
				Door ();
			game_control.GetComponent<GameControl> ().ChangeScene ();
		}
	}

	void WashedHands(){
		game_control.GetComponent<PlayerHealth> ().changeHealth (2);
	}

	void Door(){
		game_control.GetComponent<PlayerHealth> ().changeHealth (-2);
	}


}
