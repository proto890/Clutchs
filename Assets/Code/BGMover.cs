using UnityEngine;
using System.Collections;

public class BGMover : MonoBehaviour {

	public float scrollSpeed;
	public float tileSizeZ;

	private Vector3 start;



	// Use this for initialization
	void Start () {
		start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);
		transform.position = start + Vector3.forward * newPosition;
	}
}
