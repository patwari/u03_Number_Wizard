using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int max = 100;
	int min = 1;
	int guess;
	void Start () {

		Debug.Log ("Welcome to Number wizard");
		Debug.Log ("Pick a number");
		Debug.Log ("The highest number you can pick is: " + max);
		Debug.Log ("The lowest number you can pick is: " + min);
		Debug.Log ("Tell me if you number is higher or lower than my guess");
		Debug.Log ("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
		guess = (min + max) / 2;
		printMessage (guess);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.Return)) {
			ClearLog ();
			Debug.Log ("Yeeee!!! I guessed it. Your number is: " + guess);
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (min + max) / 2;
			printMessage (guess);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = (min + max) / 2;
			printMessage (guess);
		}
	}

	public void printMessage (int guess) {
		Debug.Log ("Is it higher or lower than: " + guess + "? ");
	}

	public void ClearLog () {
		var assembly = Assembly.GetAssembly (typeof (UnityEditor.Editor));
		var type = assembly.GetType ("UnityEditor.LogEntries");
		var method = type.GetMethod ("Clear");
		method.Invoke (new object (), null);
	}
}
