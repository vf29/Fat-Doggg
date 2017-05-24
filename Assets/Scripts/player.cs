using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
private Animator anim;
private Rigidbody2D rb;
private bool jump = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			anim.Play ("Jump");
			rb.gravityScale = 0;
			jump = true;
		}
	}
	void FixedUpdate () {
	if (jump == true) {
		jump = false;
		rb.AddForce(new Vector2 (0,20f), ForceMode2D.Impulse);
}
	}

}
