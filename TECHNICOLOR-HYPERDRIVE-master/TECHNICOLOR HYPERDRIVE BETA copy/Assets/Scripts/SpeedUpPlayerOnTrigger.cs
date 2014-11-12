using UnityEngine;
using System.Collections;

public class SpeedUpPlayerOnTrigger : MonoBehaviour {

	public float speedUpAmount = 1.0f;
	public float coolDownTime = 1.0f;

	private bool inCoolDown = false;
	private bool showSpeedIndicatorGui = false;

	void OnTriggerEnter(){
		if (!inCoolDown) {
			SpeedManager.Instance.SpeedUpPlayer (speedUpAmount);
			//MoveForward.speed+=MoveForward.speedBoost;
			inCoolDown = true;
			Invoke ("Uncool", coolDownTime);
		}
	}

	void OnGUI()
	{
		if (!inCoolDown)
		{
			showSpeedIndicatorGui = true;
		}

		else 
		{
			showSpeedIndicatorGui = false;
		}

		if (showSpeedIndicatorGui == true)			
		{		
			Debug.Log("ITS TRUE CAPTAIN");
			GUI.Box(new Rect(100,100,Screen.width /2, Screen.height / 2), "SPEED UP");
		}

		else if (showSpeedIndicatorGui == false)
		{
			//Debug.Log("ITS FALSE CAPTAIN");
		}
	}

	void Uncool(){
		inCoolDown = false;
	}
}
