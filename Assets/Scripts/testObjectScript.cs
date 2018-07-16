using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testObjectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("difficulty: " + PlayerPrefManager.GetDifficulty ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
