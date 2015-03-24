using UnityEngine;
using System.Collections;

public class TouchReturn : MonoBehaviour {

	public GameObject Animal;
	public GameObject TouchPads;
	public GameObject twoDContainer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 | Input.GetMouseButton(0)) {
			Animal.SetActive(false);

			TouchPads.SetActive(true);
			twoDContainer.SetActive(true);
				}


	}
}
