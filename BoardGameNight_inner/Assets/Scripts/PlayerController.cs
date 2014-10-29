using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public GameObject myChild; 

	//Inspector Variables
	public float playerSpeed = 2; //speed player moves

	// Update is called once per frame
	void Update () {

		MoveForward(); // Player Movement
		TurnRightAndLeft();//Player Turning
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (" We are inside the collider ");
		if (coll.gameObject.tag == "Coworker") {
			Debug.Log (" We are inside the Coworker collider ");
			myChild.SetActive (true);
			myChild.transform.renderer.enabled = true;
		}

	}

	void OnCollisionStay2D( Collision2D coll) {
	}


	void OnCollisionExit2D(Collision2D coll) {
		Debug.Log (" We are exiting the collider ");
		if (coll.gameObject.tag == "Coworker") {
			Debug.Log (" We are exiting the coworker collider ");
			//CoworkerScript pushedCoworkerScript = coll.gameObject.GetComponent <CoworkerScript>();
			//pushedCoworkerScript.touchingHome = false; 
			myChild.transform.renderer.enabled = false;
			myChild.SetActive (false);

		}
	}

	public void MoveForward()
	{

		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		if(Input.GetKey("down"))//Press down arrow key to move back on the Y AXIS
		{
			transform.Translate(0, (-1* playerSpeed * Time.deltaTime),0);
		}

	}
	public void TurnRightAndLeft()
	{

		if (Input.GetKey ("right")) { //Right arrow key to turn right
			//transform.Rotate (-Vector3.forward * turnSpeed * Time.deltaTime);
			transform.Translate(playerSpeed * Time.deltaTime,0,0);
		}

		if (Input.GetKey ("left")) {//Left arrow key to turn left
			//transform.Rotate (Vector3.forward * turnSpeed * Time.deltaTime);
			transform.Translate(-1*playerSpeed * Time.deltaTime,0,0);
		}
	}
}

