using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashLevelManager : MonoBehaviour {
	public float autoLoadNextLevelAfterSeconds;

	public void Start() {
		Invoke ("LoadNextLevel", autoLoadNextLevelAfterSeconds);
	}
	public void LoadLevel (string lvlname) {
		//Debug.Log ("Level load requested: " + name);
		SceneManager.LoadScene(lvlname);
	}
		
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
