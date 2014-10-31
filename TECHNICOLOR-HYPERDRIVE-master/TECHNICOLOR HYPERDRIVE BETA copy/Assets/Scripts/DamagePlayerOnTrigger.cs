using UnityEngine;
using System.Collections;

public class DamagePlayerOnTrigger : MonoBehaviour {

	public float damageAmount = 1.0f;
	public float coolDownTime = 1.0f;

	//Lower Multiplier by 1
	public int lowerMultiplyAmount = 1;

	private bool inCoolDown = false;

	void OnTriggerEnter(){
		if (!inCoolDown) {
			HealthManager.Instance.DamagePlayer (damageAmount);
			ScoreManager.Instance.LowerMultiplier (lowerMultiplyAmount); //Lower Multiplier by 1 when triggered
			inCoolDown = true;
			Invoke ("Uncool", coolDownTime);
		}
	}

	void Uncool(){
		inCoolDown = false;
	}
}
