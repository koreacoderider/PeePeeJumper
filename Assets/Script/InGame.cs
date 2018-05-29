using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float jumpGroundForce;

	// Use this for initialization
	void Start () {
		//Debug.Log("1");
		rb2d = GetComponent<Rigidbody2D>();
		jumpGroundForce = 200;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void JumpByGround(){
		
		rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
		rb2d.AddForce(new Vector2(0, jumpGroundForce));
	}
}
