using UnityEngine;
using System.Collections;

public class ContactDestroy : MonoBehaviour {

	public int scoreUpdate;
	private GameController gameController;
	// Use this for initialization


	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
		


	void OnTriggerEnter(Collider other) 
	{


		if (other.tag == "Road")
		{
			Debug.Log ("Wat");
			return;
			//Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
		else if (other.tag == "Boundary") {
			scoreUpdate += 1;
			gameController.AddScore (scoreUpdate);
			Debug.Log("Nuts");
			return;

		}
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
