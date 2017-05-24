using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {
	[SerializeField] private float objectSpeed = 100;
	private float resetPosition = -38.89f;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.left * (objectSpeed * Time.deltaTime));
		if (transform.localPosition.x <= resetPosition) {
			Vector2 newPos = new Vector2 (36.7f, transform.position.y);
			transform.position = newPos;
		}
	}
}
