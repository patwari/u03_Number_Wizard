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
	}

	void Update () {

	}
}
