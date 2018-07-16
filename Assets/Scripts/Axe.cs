using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		GameObject colObj = col.gameObject;
		if (colObj.GetComponent<AttackerScript> () && colObj.GetComponent<Health>()) {
			
		}
	}

}
