using UnityEngine;
using System.Collections;

public class gameOverScript : MonoBehaviour 
{
	public GUISkin tryAgainSkin;
	public GUISkin mainMenuSkin;

	Rect windowRect0 = new Rect(Screen.width/2 - 350, Screen.height/2 - 150, 700, 300);
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
		GUI.skin = tryAgainSkin;

		if (GUI.Button(new Rect(Screen.width/2 - 525, Screen.height/2 - 400, 400, 200), " "))
		{
			Application.LoadLevel("TestingPlayerMove");
			ScoreManager.score = 0;
		}

		GUI.skin = mainMenuSkin;

		if (GUI.Button(new Rect(Screen.width/2 - 525, Screen.height/2 - 300, 400, 200), " "))
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

//		if (health.isDead == true)
//		{
			windowRect0 = GUI.Window(0, windowRect0, DoMyWindow, "You did so good!");
//		}
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
