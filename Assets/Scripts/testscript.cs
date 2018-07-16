using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testscript : MonoBehaviour {
	public static int numberOfLevels;
	// Use this for initialization
	void Start () {
		numberOfLevels = SceneManager.GetActiveScene ().buildIndex;
		//print (numberOfLevels);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
