using UnityEngine;
using System.Collections;

public class AnimationWarrior2h : MonoBehaviour {
    public Sprite[] sprites;
    public float framesPerSecond;
    Animator anim;
    // Use this for initialization

    private SpriteRenderer _spriteRenderer;
	void Start ()
    {
        this._spriteRenderer = gameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
        anim = GetComponent<Animator>();
	}
	

    void Update()
    {
        int index = (int)(Time.timeSinceLevelLoad * this.framesPerSecond);
        index %= (this.sprites.Length - 1);
    }
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetMouseButtonDown(0))
            anim.SetInteger("lMouse", 1);         
             
            //Debug.Log("Pressed left click.");
        else 
        {
            anim.SetInteger("lMouse", 0);
        }


        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right click.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");

    }
}
