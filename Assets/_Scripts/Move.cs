using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    // Use this for initialization
    public Vector2 move = new Vector2(0.0f, 0.0f);

    private Vector2 newPosition = new Vector2(00f, 0.0f);
	void Start ()
    {
     
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        newPosition = gameObject.GetComponent<Transform>().position;

     if (Input.GetAxis ("Horizontal") > 0)
        {
            newPosition.x += this.move.x;
            gameObject.GetComponent<Transform>().position = newPosition;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            newPosition.x -= this.move.x;
            gameObject.GetComponent<Transform>().position = newPosition;
        }
        ///////////////////////////////////////////////////////////////////////
        if (Input.GetAxis("Vertical") > 0)
        {
            newPosition.y += this.move.y;
            gameObject.GetComponent<Transform>().position = newPosition;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            newPosition.y -= this.move.y;
            gameObject.GetComponent<Transform>().position = newPosition;
        }


    }
}
