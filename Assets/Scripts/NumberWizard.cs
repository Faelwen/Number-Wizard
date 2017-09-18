using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int min = 0;
		int max = 1000;

		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me.");

		print ("The lowest number you can pick is " + min);
		print ("The highest number you can pick is " + max);

		print ("Is the number higher or lower than 500?");
		print ("Up arrow for higher, down for lower, return for equal.");


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed.");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed.");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
		}
	}
}
