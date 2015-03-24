using UnityEngine;
using System.Collections;

public class ReturnToMix: MonoBehaviour {
	
	public GameObject Elephant;
	public GameObject Zebra;
	public GameObject Bear;
	public GameObject Stag;
	public GameObject Lion;
	public GameObject Wolf;
	public GameObject Rhino;
	public GameObject TouchPads;
	public GameObject twoDContainer;

	public void ResetTo2D () {

		Elephant.SetActive(false);
		Zebra.SetActive(false);
		Bear.SetActive(false);
		Stag.SetActive(false);
		Lion.SetActive(false);
		Wolf.SetActive(false);
		Rhino.SetActive(false);

			TouchPads.SetActive(true);
			twoDContainer.SetActive(true);


	}
}
