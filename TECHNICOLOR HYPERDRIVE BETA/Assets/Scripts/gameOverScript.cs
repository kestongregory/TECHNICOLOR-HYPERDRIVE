using UnityEngine;
using System.Collections;

public class gameOverScript : MonoBehaviour 
{
	Rect windowRect0 = new Rect(Screen.width/2 - 400, Screen.height/2 - 150, 800, 300);
	HealthManager health = new HealthManager();
	ScoreManager score = new ScoreManager();

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{	
	
	}

	void DoMyWindow(int windowID) 
	{
		if (GUI.Button(new Rect(Screen.width/2 - 225, Screen.height/2 - 200, 400, 100), "Try Again"))
		{
			Application.LoadLevel("TestingPlayerMove");
		}
		
		if (GUI.Button(new Rect(Screen.width/2 - 225, Screen.height/2 - 75, 400, 100), "Main Menu"))
		{
			Application.LoadLevel("mainMenu");
			print("quit");
			Time.timeScale = 1.0f;
			DestroyAllGameObjects();
		}
	}

	void OnGUI()
	{
		GUILayout.Label ("Score: " + ScoreManager.score);

		if (health.isDead == true)
		{
			windowRect0 = GUI.Window(0, windowRect0, DoMyWindow, "YOU'RE DEAD");
		}
	}

	public void DestroyAllGameObjects()
	{
		GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);
		
		for (int i = 0; i < GameObjects.Length; i++)
		{
			Destroy(GameObjects[i]);
		}
	}
}
