using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_KEY = "level_unlocked_";
	const string DIFFICULTY_KEY = "difficulty";

	// volume functions
	public static void SetMasterVolume (float volume) {
		if (volume > 0f && volume < 1f){
		PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else{
			Debug.LogError("volume out of range");
		}
	}

	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}


	// level unlocks
	public static void UnlockLevel (int level){
		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1); //Use 1 for true, since we can't use bools.

		} else {
			Debug.LogError ("trying to unlock level that is not in build order");
		}
	}

	public static bool IsLevelUnlocked(int level){
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			return isLevelUnlocked;
		} else {
			return false;
			Debug.LogError ("trying to query level that is not in build order");
		}
	}

	// difficulty functions
	public static void SetDifficulty(float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("difficulty out of range");
		}
	}

	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}

}
