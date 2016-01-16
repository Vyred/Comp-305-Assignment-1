using UnityEngine;
using System.Collections;


public class IslandController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed;
    int xForRand;
	// Use this for initialization
	void Start () {
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= speed;
        gameObject.GetComponent<Transform> ().position = currentPosition;

		// Check bottom boundary
		if (currentPosition.y <= -270) {
			this._Reset();
		}
	}

	private void _Reset() {
        var numberX = Random.Range(-250, 250);
        var numberY = Random.Range(270, 650);
        Vector2 resetPosition = new Vector2 (numberX, numberY);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
