using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalSettings : MonoBehaviour {

	public bool BackGroundSounds=true;
	public bool AnimalSounds=true;

	public Toggle BackgroundSoundsButton;
	public Toggle AnimalSoundsButton;

	void Start(){

		if (PlayerPrefs.GetInt("BackGroundSounds") == 1)
			BackgroundSoundsButton.isOn = false;
		else
			BackgroundSoundsButton.isOn = true;

		if (PlayerPrefs.GetInt("AnimalSounds") == 1)
			AnimalSoundsButton.isOn = false;
		else
			AnimalSoundsButton.isOn = true;
		
	
		}

	private void OnEnable()
	{
		BackgroundSoundsButton.onValueChanged.AddListener(ToggleBackgroundSounds);
		AnimalSoundsButton.onValueChanged.AddListener(ToggleAnimalSounds);
	}

	private void OnDisable()
	{
		BackgroundSoundsButton.onValueChanged.RemoveListener (ToggleBackgroundSounds);
		BackgroundSoundsButton.onValueChanged.RemoveListener (ToggleAnimalSounds);
	}
		
	void ToggleBackgroundSounds(bool checkbox){
		if (checkbox)
			PlayerPrefs.SetInt("BackGroundSounds",0);
		else
			PlayerPrefs.SetInt("BackGroundSounds",1);
	}

	void ToggleAnimalSounds(bool checkbox){
		if (checkbox)
			PlayerPrefs.SetInt("AnimalSounds",0);
		else
			PlayerPrefs.SetInt("AnimalSounds",1);
	}
		

}
