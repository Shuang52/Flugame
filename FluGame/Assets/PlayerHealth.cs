using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	int player_health = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Vaccine(){
		player_health += 5;
	}

	public int health{
		get{ return player_health;}
		set{ player_health = value;}
	}
}
