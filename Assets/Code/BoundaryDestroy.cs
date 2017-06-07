using UnityEngine;
using System.Collections;
//Script used for boundaries, to destroy objects that pass the player
public class BoundaryDestroy : MonoBehaviour {
	//Function that triggers when it detects a collider
	  void OnTriggerExit(Collider other) {


		//if (other.tag == "Hazard")
		//{
			Destroy(other.gameObject);//Destroys the game object

		//}



    }

}