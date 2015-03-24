using UnityEngine;
using System.Collections;

public class ElephantAnimation : MonoBehaviour {

	public Animator anim;
	public AudioClip Trumpet;

	public float waitTime = 2.0f;
	private bool played = false;
	private AudioSource source;


	void Awake(){
		anim = GetComponent<Animator> ();
		source = GetComponent<AudioSource> (); 

		}

	void Start()
	{

		anim.SetTrigger ("trumpet");

		}


	void Update(){

		if (anim.animation.name == "idleEat") {
				source.PlayOneShot (Trumpet);
				}


//			if(!played)
//			{
//				if(waitTime > 0){
//					waitTime -= Time.deltaTime;	
//				}
//
//				if(waitTime <= 0){	
//					played = true;	
//					source.PlayOneShot (Trumpet);
//					}
//			}
		}

}
