using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManagerScript : MonoBehaviour {

	public AudioClip[] levelMusicArray;

	private AudioSource audioSauce;

	void Awake (){
		DontDestroyOnLoad (gameObject);
	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void Start () {
		audioSauce = GetComponent<AudioSource>();
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Scene currentScene = SceneManager.GetActiveScene();
		int currentBuildIndex = currentScene.buildIndex;
		Debug.Log(currentBuildIndex);

		AudioClip thisLevelsMusic = levelMusicArray [currentBuildIndex];

		Debug.Log ("Playing level: " + thisLevelsMusic);
		if (thisLevelsMusic) {
			audioSauce.clip = thisLevelsMusic;
			audioSauce.loop = true;
			audioSauce.Play ();
		}
	}
	
	/* 
	void OnLevelWasLoaded(int level) {

		AudioClip thisLevelsMusic = levelMusicArray [level];

		Debug.Log ("Playing level: " + thisLevelsMusic);
		if (thisLevelsMusic) {
			audioSauce.clip = thisLevelsMusic;
			audioSauce.loop = true;
			audioSauce.Play ();
		}
	}
	*/
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeVolume (float volume) {
		audioSauce.volume = volume;
	}
}
