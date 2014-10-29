using UnityEngine;
using System.Collections;

public class FireExtinguisher : MonoBehaviour {


	public GameObject mainPlayer;
	public ParticleSystem foam;

	void OnCollisionEnter2D( ){
		transform.parent = mainPlayer.transform;

	}

	void Update(){
		if (Input.GetKeyDown ("space")) {
			foam.Play ();
		}
	}
}
