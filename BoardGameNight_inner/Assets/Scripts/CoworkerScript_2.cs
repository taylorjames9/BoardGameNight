using UnityEngine;
using System.Collections;

public class CoworkerScript_2 : MonoBehaviour {


	public bool touchingHome = true;
	public bool returningHome;
	public GameObject myHomeBase;
	private Vector2 currentPosition;

	void Update(){

		Debug.Log ("touching home = " + touchingHome);
		currentPosition = transform.position; 

		if (!touchingHome && returningHome) {
			Debug.Log ("We shoudl be lerping in the update function");
			transform.position = Vector2.Lerp (currentPosition, myHomeBase.transform.position, Time.deltaTime);
		}

	}

	//if I'm touching home, do nothing

	//if I am not touching home and I am not touching "MAIN" player, return home. 


	void OnCollisionEnter2D(Collision2D coll) {
		touchingHome = true;
	}

	void OnCollisionStay2D( Collision2D coll) {
		touchingHome = true;
	}


	void OnCollisionExit2D(Collision2D coll) {
		touchingHome = false;
		StartCoroutine(returnHome());

	}

	public IEnumerator returnHome(){
		returningHome = true;
		Debug.Log ("we should be returning home");
		//if (!touchingHome) {
		transform.position = Vector2.Lerp (currentPosition, myHomeBase.transform.position, Time.deltaTime/3);
		//}

		yield return null;
	}

}
