using UnityEngine;
using System.Collections;

public class InstructionsDisappear : MonoBehaviour {

	void Start(){
		this.renderer.enabled = true;
	}


	void OnMouseDown(){
		//this.renderer.enabled = false;
		gameObject.SetActive (false);
	}


}
