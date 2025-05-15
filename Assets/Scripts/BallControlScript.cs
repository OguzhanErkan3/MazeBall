using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControlScript : MonoBehaviour {

	// Reference to Rigidbody2D component of the ball game object
	Rigidbody rb;

	// Range option so moveSpeedModifier can be modified in Inspector
	// this variable helps to simulate objects acceleration
	[Range(0.2f, 2f)]
	public float moveSpeedModifier = 0.5f;

	// Direction variables that read acceleration input to be added
	// as velocity to Rigidbody2d component
	float dirX, dirY;

	// Reference to Balls Animator component to control animaations transition
	

	// Setting bool variable that ball is alive at the beginning

	// Variable to allow or disallow movement when ball is alive or dead




	// Use this for initialization
	void Start () {


		// Getting Rigidbody2D component of the ball game object
		rb = GetComponent<Rigidbody> ();

		

	}
	
	// Update is called once per frame
	void Update () {

		// Getting devices accelerometer data in X and Y direction
		// multiplied by move speed modifier
		dirX = Input.acceleration.x * moveSpeedModifier;
		dirY = Input.acceleration.y * moveSpeedModifier;


	

		

	}

	void FixedUpdate()
	{
		
		rb.velocity = new Vector3 (rb.velocity.x + dirX, rb.velocity.y + dirY);
	}

	// Method is invoked by DeathHoleScript when ball touches deathHole collider
	

	


}
