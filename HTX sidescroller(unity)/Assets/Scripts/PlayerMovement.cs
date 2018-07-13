using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	public float playerMaxSpeed;
	Rigidbody2D playerRB;
	Animator animator;
	bool isFacingRight;

	void Start () {
		// Gets the players rigidbody component aswell as the animator.
		playerRB = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate() {
		float move = Input.GetAxis("Horizontal");
		playerRB.velocity = new Vector2(move * playerMaxSpeed, playerRB.velocity.y);

		if(move > 0 && !isFacingRight)
		{
			flip();
		}
		else if (move < 0 && isFacingRight)
		{
			flip();
		}
	}

	void flip()
	{
		isFacingRight = !isFacingRight;
		Vector3 scale = transform.localScale;
		scale.x = scale.x * -1;
		transform.localScale = scale;
	}
}
