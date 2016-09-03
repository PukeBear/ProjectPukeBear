using UnityEngine;
using System.Collections;


public class LevelLoader : MonoBehaviour {
	bool pukeCheck = false;
	bool counterCheck = false;
	public int counter = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
   
	//bool dicks = true;
	void FixedUpdate () {
		// Getting Stuff 

		GameObject bearr = GameObject.Find("Bear Head");
		BearController bearScript = bearr.GetComponent<BearController>();
		pukeCheck = bearScript.puked; 

		// Checking for Puke and Counting 
		if (pukeCheck)
		{	
			counter++;
		}
	
	}

}
