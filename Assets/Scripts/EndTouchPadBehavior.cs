using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;
using TouchScript.Hit;

public class EndTouchPadBehaviour : MonoBehaviour {

	public GameObject leftPic;
	//public Sprite midPic;
	//public Sprite rightPic;

	private void OnEnable()
	{
		//GetComponent<TapGesture>().Tapped += tappedHandler;
		//GetComponent<FlickGesture>().Flicked += tappedHandler;
	}
	
	private void OnDisable()
	{
		//GetComponent<FlickGesture>().Flicked -= tappedHandler;
	}
	
	private void tappedHandler(object sender, EventArgs e)
	{

//		if (((FlickGesture)sender).ScreenFlickVector.y > 0) {
//			leftPic.transform.localPosition = new Vector3 (0, 2);	
//		} 
//		else 
//		{
//			leftPic.transform.localPosition = new Vector3 (0, -2);
//		}
		//this.transform.localPosition = new Vector3 (0, 2);
		//this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 1));

	}
}
