﻿using System.Collections;
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

	public void changeHealth(int number){
		player_health += number;
	}

	public int health{
		get{ return player_health;}
		set{ player_health = value;}
	}
}
