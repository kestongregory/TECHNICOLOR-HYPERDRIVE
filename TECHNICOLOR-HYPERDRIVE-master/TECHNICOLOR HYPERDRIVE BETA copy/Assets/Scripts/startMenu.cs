using UnityEngine;
using System.Collections;

public class startMenu : MonoBehaviour 
{
	public GUISkin startSkin;
	public GUISkin quitSkin;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI () 
	{
		GUI.skin = startSkin;
	
		if (GUI.Button(new Rect(Screen.width/2 - 250,Screen.height/2 - 175,500,300), ""))
		{
			Debug.Log("you clicked the start button");
			Application.LoadLevel("howToPlay");
		}

		GUI.skin = quitSkin;

		if (GUI.Button(new Rect(Screen.width/2 - 250,Screen.height/2 - 50,500,300), ""))
		{
			Debug.Log("you clicked the quit button");
			Application.Quit();
		}
	}
}
