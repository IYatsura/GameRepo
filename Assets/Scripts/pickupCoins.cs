﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupCoins : MonoBehaviour {
	public int scoreToGive;
	private ScoreManager theScoreManager;
	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Cat") 
		{
			theScoreManager.AddScore(scoreToGive);
			gameObject.SetActive (false);
		}
	}
}
