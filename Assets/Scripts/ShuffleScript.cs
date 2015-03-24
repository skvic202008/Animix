using UnityEngine;
using System.Collections;

public class ShuffleScript : MonoBehaviour {

	public GameObject EBack;
	public GameObject EMiddle;
	public GameObject EFront;

	public GameObject EBackZebra;
	public GameObject EMiddleZebra;
	public GameObject EFrontZebra;

	public GameObject EBackLion;
	public GameObject EMiddleLion;
	public GameObject EFrontLion;

	public GameObject EBackBear;
	public GameObject EMiddleBear;
	public GameObject EFrontBear;

	public GameObject EBackStag;
	public GameObject EMiddleStag;
	public GameObject EFrontStag;

	// Use this for initialization
	void Start () {
		EBack.transform.position = new Vector3 (EBack.transform.position.x, EBack.transform.position.y + 20);
		EMiddle.transform.position = new Vector3 (EMiddle.transform.position.x, EMiddle.transform.position.y + 40 );
		EFront.transform.position = new Vector3 (EFront.transform.position.x, EFront.transform.position.y + 10);

		EBackZebra.transform.position = new Vector3 (EBackZebra.transform.position.x, EBackZebra.transform.position.y );
		EMiddleZebra.transform.position = new Vector3 (EMiddleZebra.transform.position.x, EMiddleZebra.transform.position.y );
		EFrontZebra.transform.position = new Vector3 (EFrontZebra.transform.position.x, EFrontZebra.transform.position.y -10);

		EBackLion.transform.position = new Vector3 (EBackLion.transform.position.x, EBackLion.transform.position.y - 20);
		EMiddleLion.transform.position = new Vector3 (EMiddleLion.transform.position.x, EMiddleLion.transform.position.y);
		EFrontLion.transform.position = new Vector3 (EFrontLion.transform.position.x, EFrontLion.transform.position.y + 10);

		EBackBear.transform.position = new Vector3 (EBackBear.transform.position.x, EBackBear.transform.position.y);
		EMiddleBear.transform.position = new Vector3 (EMiddleBear.transform.position.x, EMiddleBear.transform.position.y);
		EFrontBear.transform.position = new Vector3 (EFrontBear.transform.position.x, EFrontBear.transform.position.y -10);

		EBackStag.transform.position = new Vector3 (EBackStag.transform.position.x, EBackStag.transform.position.y);
		EMiddleStag.transform.position = new Vector3 (EMiddleStag.transform.position.x, EMiddleStag.transform.position.y -40);
		EFrontStag.transform.position = new Vector3 (EFrontStag.transform.position.x, EFrontStag.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
