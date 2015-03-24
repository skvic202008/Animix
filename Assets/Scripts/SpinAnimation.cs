using UnityEngine;
using System.Collections;

public class SpinAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update(){
		if (Input.GetMouseButton(0)) {
			transform.Rotate(0f, Input.mousePosition.x * Time.deltaTime * 0.1f, 0f);
		}
		}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.touchCount > 0 && 
		    Input.GetTouch(0).phase == TouchPhase.Moved) {
			
			// Get movement of the finger since last frame
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
				transform.Rotate(0f, touchDeltaPosition.x * -1 * Time.deltaTime * 30, 0f);
			}
		}

	}
}
