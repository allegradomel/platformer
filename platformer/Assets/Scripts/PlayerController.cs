using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJumped;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);	
	}


	
	// Update is called once per frame
	void Update () {
		if (grounded) {
			doubleJumped = false; 
		}



		if(Input.GetKeyDown (KeyCode.UpArrow) && grounded)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			
		}
		if(Input.GetKeyDown (KeyCode.UpArrow) && !doubleJumped && !grounded)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			doubleJumped = true;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}



}
}
