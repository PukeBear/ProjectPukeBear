using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BearController : MonoBehaviour {
	public float maxSpeed = 25f;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 2.07f;
	public LayerMask whatIsGround;
	public bool puked = false;
	float upDown;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		float movex = Input.GetAxis ("Horizontal");
		upDown = transform.position.y;

		bool jumper = Input.GetKey ("up");
		float spinn = GetComponent<Rigidbody2D> ().angularVelocity;
		GetComponent<Rigidbody2D>().velocity = new Vector2(movex * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (grounded && jumper) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, maxSpeed);
		}

		if (spinn > 800 || spinn < -800) {
			puked = true;
		} else puked = false;
		GetComponent<ParticleSystem>().enableEmission = puked;
		if (upDown < -50) {
			gameOver ();
		}


		//Debug.Log (puked);
		//Debug.Log (spinn);

				

	}
	void gameOver() {
		int sceneNumber = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (sceneNumber);
	} 

}

