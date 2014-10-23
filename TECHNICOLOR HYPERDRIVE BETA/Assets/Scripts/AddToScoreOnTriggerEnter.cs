﻿using UnityEngine;
using System.Collections;

public class AddToScoreOnTriggerEnter : MonoBehaviour {
	//MoveForward instance = new MoveForward();
	public int pointValue = 1;
	public int UpMultiplierAmount = 1;
	
	// Update is called once per frame
	void OnTriggerEnter() {
		ScoreManager.score += pointValue*(ScoreManager.Instance.currentMultiply);
		RingCountManager.Instance.currentRingCount++;
		if (RingCountManager.Instance.currentRingCount % 5 == 0) {
			ScoreManager.Instance.UpMultiplier (UpMultiplierAmount); //Up Multiplier by 1
		}
	}
}
