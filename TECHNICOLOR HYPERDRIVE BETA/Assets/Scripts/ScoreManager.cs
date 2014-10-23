using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	
	public int currentLevel = 0;
	public int[] levelScoreThresholds;
	public static int score = 0;

	public delegate void LevelChangedEvent(int newlevel);
	public event LevelChangedEvent LevelChanged;

	
	void OnGUI(){
		GUILayout.Label ("Score: " + score + " X " + currentMultiply);
	}

	/////////////////////////////////////////////////////////////
	public int maxMultiply = 10;
	public int minMultiply= 1;
	public int currentMultiply;
	
	// Use this for initialization
	void Start () {
		currentMultiply = 1;
		InvokeRepeating("scoreCounter", 1, 1);
	}
	
	//void OnGUI(){
	//	GUILayout.Label ("MULTIPLIER: " + currentMultiply);
	//}
	
	public void LowerMultiplier(int lowerAmount){
		if (lowerAmount < 0) {
			Debug.LogError ("Cannot post a negative value to LowerMultiplier. Please use UpMultiplier instead.");
			return;
		}
		
		currentMultiply -= lowerAmount;
		if (currentMultiply < minMultiply) {
			currentMultiply = minMultiply;
		}
	}
	
	public void UpMultiplier(int upAmount){
		if (upAmount < 0) {
			Debug.LogError("Cannot post a negative value to SpeedUpPlayer. Please use SpeedDownPlayer instead.");
			return;
		}
		currentMultiply += upAmount;
		
		if (currentMultiply > maxMultiply) {
			currentMultiply = maxMultiply;
			
		}
	}
	/////////////////////////////////////////////////////////////

	void Update(){

		/*if (Input.GetButtonDown ("Fire1"))
		{
			UpMultiplier(1);
		}
		if (Input.GetButtonDown ("Fire2"))
		{
			LowerMultiplier(1);
		}*/

		//gamestate handler
		if(score > levelScoreThresholds[currentLevel]){
			currentLevel += 1;
			//send notification of some kind to the other objects that care
			LevelChanged(currentLevel);
		}
	}

	#region SingletonAndAwake
	private static ScoreManager instance = null;
	public static ScoreManager Instance{
		get {return instance;}
	}
	void Awake(){
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
		gameObject.name = "$ScoreManager";
	}
	#endregion

	void scoreCounter()
	{
		score = score + (10 * currentMultiply);
	}
}
