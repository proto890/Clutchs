using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

public float speed;

private Rigidbody player;



	// Use this for initialization
	void Start () {
					player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
					transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);

					float moveHori = Input.GetAxis ("Horizontal");
					
					float moveVeri = Input.GetAxis ("Vertical");

					Vector3 movement = new Vector3 (moveHori, 0.0f, moveVeri);

        			player.AddForce (movement * speed);


	}
}
