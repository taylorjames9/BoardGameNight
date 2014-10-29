using UnityEngine;
using System.Collections;

public class ChestOpen : MonoBehaviour {


	int hitCounter = 0;

	public GameObject myFireExtinguisher;
	//ArrayList<GameObject> chestItems = new ArrayList<GameObject> ();
	GameObject[] chestItems;

	void Start(){
		//chestItems.add (myFireExtinguisher);
		myFireExtinguisher.SetActive (false);
	}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Main") {
			hitCounter++;
			myFireExtinguisher.SetActive (true);

		}
	}
}
