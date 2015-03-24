using UnityEngine;
using System.Collections;

public class InitializeScene : MonoBehaviour {

	public AudioSource source;
	public AudioSource Elephant;
	public AudioSource Stag;
	public AudioSource Bear;
	public AudioSource Zebra;
	public AudioSource Lion;
	public AudioSource Wolf;
	public AudioSource Rhino;

	void Start(){

		// 0 is On
		if (PlayerPrefs.GetInt ("BackGroundSounds") == 0)
						source.Play ();
				else
						source.Stop ();


		if (PlayerPrefs.GetInt ("AnimalSounds") == 0) {
			Elephant.playOnAwake = true;
			Stag.playOnAwake = true;
			Bear.playOnAwake = true;
			Zebra.playOnAwake = true;
			Zebra.playOnAwake = true;
			Lion.playOnAwake = true;
			Wolf.playOnAwake = true;
			Rhino.playOnAwake = true;
				} else {
			Elephant.playOnAwake = false;
			Stag.playOnAwake = false;
			Bear.playOnAwake = false;
			Zebra.playOnAwake = false;
			Zebra.playOnAwake = false;
			Lion.playOnAwake = false;
			Wolf.playOnAwake = false;
			Rhino.playOnAwake = false;
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
