using UnityEngine;
using System.Collections;

public class bgMover : MonoBehaviour 
{
	GameObject bgPlanes;
	Camera mainCam;
	bool bgChecker = false;
	bool planet1Checker = false;
	public float bgScrollRate = 15;

	// Use this for initialization
	void Start () 
	{
		bgPlanes = GameObject.Find("bgPlane");
	}

	
	// Update is called once per frame
	void Update () 
	{
		//move the background

		//////////////////////////////////////////////////////////////////////////////////

		if (bgPlanes.transform.position.y >= 9.5)
		{
			bgChecker = true;
		}

		else if (bgPlanes.transform.position.y <= 2)
		{
			bgChecker = false;
		}

		if (bgChecker == true)
		{
			bgPlanes.transform.Translate(Vector3.down * Time.deltaTime / bgScrollRate, Space.World);
		}

		else
		{
			bgPlanes.transform.Translate(Vector3.up * Time.deltaTime / bgScrollRate, Space.World);

		}
		//////////////////////////////////////////////////////////////////////////////////
	}
}
