﻿using UnityEngine;
using System.Collections;

public class take_star : MonoBehaviour {

	game_uGUI my_game_uGUI;

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(true);
		my_game_uGUI = GameObject.FindGameObjectWithTag("_gui_").GetComponent<game_uGUI>();
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))//if the player collide with this star
			{
			if (my_game_uGUI.star_number<3)
				{
				my_game_uGUI.star_number++;//add star
				my_game_uGUI.stars_count.text = my_game_uGUI.star_number.ToString();//update gui
				}
			
			this.gameObject.SetActive(false);
			}
	}
}
