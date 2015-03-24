using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckMatch : MonoBehaviour {

	public GameObject EndContainer;
	public GameObject MiddleContainer;
	public GameObject FrontContainer;
	public Text theMessage;
	public GameObject Elephant;
	public GameObject Zebra;
	public GameObject Bear;
	public GameObject Stag;
	public GameObject Lion;
	public GameObject TouchPads;
	public GameObject twoDContainer;

	private string sentto3dby = "";


	void Awake(){
		//GetComponent<Text>
		}

	// Use this for initialization
	void Start () {
		theMessage.text = "Start";
	}
	
	// Update is called once per frame
	void Update () {

		if (sentto3dby != "Zebra") {
						if (EndContainer.transform.position.y == -8.79f && MiddleContainer.transform.position.y == -8.79f && FrontContainer.transform.position.y == 1.21f) {
								theMessage.text = "Zebra";
								sentto3dby = theMessage.text;
								Zebra.SetActive (true);
								TouchPads.SetActive (false);
								twoDContainer.SetActive (false);
			}
		}

		if (sentto3dby != "Lion") {
						if (EndContainer.transform.position.y == 1.21f && MiddleContainer.transform.position.y == -18.79f && FrontContainer.transform.position.y == -28.79f) {
								theMessage.text = "Lion";
								sentto3dby = theMessage.text;
								Lion.SetActive (true);
								TouchPads.SetActive (false);
								twoDContainer.SetActive (false);
						}
				}
		if ( sentto3dby != "Elephant") {
						if (EndContainer.transform.position.y == -18.79f && MiddleContainer.transform.position.y == -38.79f && FrontContainer.transform.position.y == -8.79f) {
								theMessage.text = "Elephant";	
								sentto3dby = theMessage.text;
								Elephant.SetActive (true);
								TouchPads.SetActive (false);
								twoDContainer.SetActive (false);
						}
				}

		if (sentto3dby != "Bear") {
						if (EndContainer.transform.position.y == -28.79f && MiddleContainer.transform.position.y == -28.79f && FrontContainer.transform.position.y == -18.79f) {
								theMessage.text = "Bear";	
								sentto3dby = theMessage.text;
								Bear.SetActive (true);
								TouchPads.SetActive (false);
								twoDContainer.SetActive (false);
						}
				}

		if (sentto3dby != "Stag") {
						if (EndContainer.transform.position.y == -38.79f && MiddleContainer.transform.position.y == 1.21f && FrontContainer.transform.position.y == -38.79f) {
								theMessage.text = "Stag";
								sentto3dby = theMessage.text;
								Stag.SetActive (true);
								TouchPads.SetActive (false);
								twoDContainer.SetActive (false);
						}
				}
	}
}
