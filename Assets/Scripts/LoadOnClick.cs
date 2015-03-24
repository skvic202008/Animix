using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
	
	public int BackGroundSounds=1;
	public int AnimalSounds=1;
	
	
	public void LoadSettings(){
		BackGroundSounds = PlayerPrefs.GetInt("BackGroundSounds");
		BackGroundSounds = PlayerPrefs.GetInt("AnimalSounds");
	}
	
	public void SaveSettings(){
		PlayerPrefs.SetInt("BackGroundSounds",BackGroundSounds) ;
		PlayerPrefs.SetInt("AnimalSounds",BackGroundSounds) ;
	}

	public void LoadScene(int Level)
	{
		Application.LoadLevel (Level);
	}
	
	public void	QuitGame()
	{
		Application.Quit ();
	}
}
