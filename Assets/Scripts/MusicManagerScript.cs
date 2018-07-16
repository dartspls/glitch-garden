using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerScript : MonoBehaviour {

	public AudioClip[] levelMusicArray;

	private AudioSource audioSauce;

	void Awake (){
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
		audioSauce = GetComponent<AudioSource>();

	}

	void OnLevelWasLoaded(int level) {

		AudioClip thisLevelsMusic = levelMusicArray [level];

		Debug.Log ("Playing level: " + thisLevelsMusic);
		if (thisLevelsMusic) {
			audioSauce.clip = thisLevelsMusic;
			audioSauce.loop = true;
			audioSauce.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeVolume (float volume) {
		audioSauce.volume = volume;
	}
}
