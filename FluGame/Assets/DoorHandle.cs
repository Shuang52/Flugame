using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DoorHandle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

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
		if(GameObject.Find("SceneControl").GetComponent<SceneControl>().narrationContinue == false)
			text.SetActive (true);
	}

	public void OnPointerClick(PointerEventData event_data){
		if (GameObject.Find ("SceneControl").GetComponent<SceneControl> ().narrationContinue == false) {		
			if (this.gameObject.name == "Blue Door") 
				GetVaccinated ();
		}
	}

	public void GetVaccinated(){
		game_control.GetComponent<PlayerHealth> ().Vaccine ();
		game_control.GetComponent<GameControl> ().ChangeScene ();
	}

	void NoVaccination(){
		game_control.GetComponent<GameControl> ().ChangeScene ();
	}
}
