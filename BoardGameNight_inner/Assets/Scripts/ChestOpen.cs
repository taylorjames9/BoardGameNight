using UnityEngine;
using System.Collections;

public class ChestOpen : MonoBehaviour {


	int hitCounter = 0;
	public Sprite openChest;
	public Sprite closedChest;

	public GameObject myFireExtinguisher;
	//ArrayList<GameObject> chestItems = new ArrayList<GameObject> ();
	GameObject[] chestItems;

	void Start(){
		//renderer.material.mainTexture = closedChest;
		gameObject.GetComponent<SpriteRenderer>().sprite = closedChest;
		myFireExtinguisher.SetActive (false);
	}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Main") {
			hitCounter++;
			myFireExtinguisher.SetActive (true);
			gameObject.GetComponent<SpriteRenderer> ().sprite = openChest;
			//renderer.material.mainTexture = openChest;
		}
	}
}
