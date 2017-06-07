using UnityEngine;
using System.Collections;

public class ContactDestroy : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{


		if (other.tag == "Road")
		{
			return;
			//Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
