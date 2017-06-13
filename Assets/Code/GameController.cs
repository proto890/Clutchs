using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public GameObject boundary;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	private int Score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
		Score = 0;
			
	}

	void Update () {
		
	}

	public void AddScore(int scoreUpdate){
		Score += scoreUpdate;
		UpdateScore ();
	}

	void UpdateScore () {
		scoreText.text = Score.ToString();
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}


