using UnityEngine;
using System.Collections;

public class howToPlayScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("space") || Input.GetMouseButton(0))
		{
			Application.LoadLevel("TestingPlayerMove");
		}
	}
}
