using System;
using TouchScript.Gestures;
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private void OnEnable()
	{
		GetComponent<FlickGesture>().Flicked += pressedHandler;

	}
	private void pressedHandler(object sender, EventArgs e)
	{
		transform.localPosition = new Vector3 (10, 10);
	}

}
