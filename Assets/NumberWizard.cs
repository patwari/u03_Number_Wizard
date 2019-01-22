using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	void Start () {
		int max = 100;
		int min = 1;

		Debug.Log ("Welcome to Number wizard");
		Debug.Log ("Pick a number");
		Debug.Log ("The highest number you can pick is: " + max);
		Debug.Log ("The lowest number you can pick is: " + min);
		Debug.Log ("Tell me if you number is higher or lower than my guess");
		Debug.Log ("Push Up = Higer, Push Down = Lower, Push Enter = Correct");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Up Arrow key was pressed");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Down Arrow key was pressed");
		}
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.Return)) {
			Debug.Log ("Enter Arrow key was pressed");
		}
	}
}
