using UnityEngine;
using System.Collections;

public class pauseScript : MonoBehaviour 
{
	Rect windowRect0 = new Rect(Screen.width/2 - 350, Screen.height/2 - 150, 700, 300);
	public bool isPaused = false;

	public GUISkin resumeSkin;
	public GUISkin mainMenuSkin;
//
//	// Use this for initialization
	void Start () 
	{

	}
	
//	// Update is called once per frame
	void Update () 
	{
		if (isPaused == false && Input.GetKeyDown("space")) 
		{
			Debug.Log("pressed space");
			Time.timeScale = 0.0f;
			isPaused = true;
		}

		else if (isPaused == true && Input.GetKeyDown("space"))
		{
			Debug.Log("pressed space");
			Time.timeScale = 1.0f;
			isPaused = false;
		}
	}

	void DoMyWindow(int windowID) 
	{
		GUI.skin = resumeSkin;

		if (GUI.Button(new Rect(Screen.width/2 - 225, Screen.height/2 - 225, 400, 200), " "))
		{
			isPaused = false;
			Time.timeScale = 1.0f;
			print("Resume");
		}
	
		GUI.skin = mainMenuSkin;

		if (GUI.Button(new Rect(Screen.width/2 - 225, Screen.height/2 - 100, 400, 200), " "))
		{
			Application.LoadLevel("mainMenu");
			print("quit");
			Time.timeScale = 1.0f;
			DestroyAllGameObjects();
		}
	}

	void OnGUI ()
	{
		if (isPaused == true)
		{
			windowRect0 = GUI.Window(0, windowRect0, DoMyWindow, "PAUSED");
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
