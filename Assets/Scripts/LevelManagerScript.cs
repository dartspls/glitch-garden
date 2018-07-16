using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour {
	public float autoLoadNextLevelAfterSeconds;

	public void Start() {
		if (autoLoadNextLevelAfterSeconds > 0) {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfterSeconds);
		} else if (autoLoadNextLevelAfterSeconds <= 0) {
			Debug.Log ("Autoload disabled. use positive number for autoload.");
		}
	}
	public void LoadLevel (string lvlname) {
		//Debug.Log ("Level load requested: " + name);
		SceneManager.LoadScene(lvlname);
	}
		
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
