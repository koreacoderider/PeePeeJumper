using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPlayerStart : MonoBehaviour {

    public float maxSpeed;
    public Rigidbody2D rigidbody2D;
   public bool faceoff;

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        

	}


    void clk() {
        flip();
    }


    public void flip() {

        faceoff = !faceoff;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    } 



}
