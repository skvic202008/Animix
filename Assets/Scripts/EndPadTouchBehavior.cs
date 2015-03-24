using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;
using TouchScript.Hit;
using UnityEngine.UI;

public class EndPadTouchBehavior : MonoBehaviour {

	public Animator anim;
	
	public GameObject LetterM;
	public GameObject LetterA;
	public GameObject LetterT;
	public GameObject LetterC;
	public GameObject LetterH;
	
	public GameObject EndContainer;
	public GameObject MiddleContainer;
	public GameObject FrontContainer;
	public Text theMessage;
	public GameObject Elephant;
	public GameObject Zebra;
	public GameObject Bear;
	public GameObject Stag;
	public GameObject Lion;
	public GameObject Wolf;
	public GameObject Rhino;
	public GameObject TouchPads;
	public GameObject twoDContainer;
	
	public GameObject PadContainer;
	//public Sprite midPic;
	//public Sprite rightPic;
	private float AnimalY;
	private float containeroffset = 1.21f;
	private string sentto3dby = "";
	private bool MovePad = false;
	private float adjustLevel = 10.0f;
	private float adjustStep = 0f;
	private float adjustedAmount = 0f;
	
	private void OnStart()
	{
		AnimalY = PadContainer.transform.position.y;
		//GetComponent<FlickGesture>().Flicked += tappedHandler;
	}
	
	private void OnEnable()
	{
		GetComponent<PanGesture>().PanStarted += tappedHandler;
		//GetComponent<FlickGesture>().Flicked += tappedHandler;
	}
	
	private void OnDisable()
	{
		GetComponent<PanGesture>().PanStarted -= tappedHandler;
		//GetComponent<FlickGesture>().Flicked -= tappedHandler;
	}
	
	private void tappedHandler(object sender, EventArgs e)
	{
		
		if (((PanGesture)sender).ScreenPosition.y > ((PanGesture)sender).PreviousScreenPosition.y) {
			//AnimalY += 10;
			MovePad = true;
			adjustedAmount = .5f;
			
			if(AnimalY == 0f)
				AnimalY = -70;
			
			//PadContainer.transform.position = new Vector3(PadContainer.transform.position.x,AnimalY + containeroffset,PadContainer.transform.position.z);
		} 
		else 
		{
			//AnimalY -= 10;
			MovePad = true;
			adjustedAmount = -.5f;
			
			if(AnimalY == -60)
				AnimalY = 10f;
			
			
			
			//PadContainer.transform.position = new Vector3(PadContainer.transform.position.x,AnimalY + containeroffset,PadContainer.transform.position.z);	
		}
		//this.transform.localPosition = new Vector3 (0, 2);
		//this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 1));

	}

	void FixedUpdate () {
		
		if (MovePad) {
			adjustStep += 1f; // track how many steps
			AnimalY += adjustedAmount;
			PadContainer.transform.position = new Vector3(PadContainer.transform.position.x,AnimalY + containeroffset,PadContainer.transform.position.z);
			if (adjustStep == 20f) 
			{
				adjustStep =0f;
				MovePad = false;
				CheckMatch ();
			}
			
			
			
		}
		
	}
	
	private void CheckMatch(){
		bool IsMatch = false;

			if (EndContainer.transform.position.y == -8.79f && MiddleContainer.transform.position.y == -8.79f && FrontContainer.transform.position.y == 1.21f) {
				Animalmatched(Zebra,"Zebra");
			}

		

			if (EndContainer.transform.position.y == 1.21f && MiddleContainer.transform.position.y == -18.79f && FrontContainer.transform.position.y == -28.79f) {
				Animalmatched(Lion,"Lion");
			}


			if (EndContainer.transform.position.y == -18.79f && MiddleContainer.transform.position.y == -38.79f && FrontContainer.transform.position.y == -8.79f) {
				Animalmatched(Elephant,"Elephant");
			}

		

			if (EndContainer.transform.position.y == -28.79f && MiddleContainer.transform.position.y == -28.79f && FrontContainer.transform.position.y == -18.79f) {
				Animalmatched(Bear,"Bear");
			}

		

			if (EndContainer.transform.position.y == -38.79f && MiddleContainer.transform.position.y == 1.21f && FrontContainer.transform.position.y == -38.79f) {
				Animalmatched(Stag,"Stag");
			}

		

			if (EndContainer.transform.position.y == -48.79f && MiddleContainer.transform.position.y == -48.79f && FrontContainer.transform.position.y == -48.79f) {
				Animalmatched(Wolf,"Wolf");
			}

		

			if (EndContainer.transform.position.y == -58.79f && MiddleContainer.transform.position.y == -58.79f && FrontContainer.transform.position.y == -58.79f) {
				Animalmatched(Rhino,"Rhino");
			}

		
	}
	
	
	private void Animalmatched(GameObject animal, string message){
		PlayMatch();
		theMessage.text = message;
		sentto3dby = theMessage.text;
		animal.SetActive (true);
		TouchPads.SetActive (false);
		twoDContainer.SetActive (false);
		
	}
	
	public void PlayMatch()
	{
		anim = LetterM.GetComponent<Animator> ();
		anim.SetTrigger ("Match");
		
		anim = LetterA.GetComponent<Animator> ();
		anim.SetTrigger ("Match");
		
		anim = LetterT.GetComponent<Animator> ();
		anim.SetTrigger ("Match");
		
		anim = LetterC.GetComponent<Animator> ();
		anim.SetTrigger ("Match");
		
		anim = LetterH.GetComponent<Animator> ();
		anim.SetTrigger ("Match");
		
	}
}
