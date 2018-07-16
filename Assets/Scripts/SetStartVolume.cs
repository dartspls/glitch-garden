using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

	private MusicManagerScript musicManager;
	private float musicVol;
	// Use this for initialization
	void Start () {
		musicVol = PlayerPrefManager.GetMasterVolume();
		musicManager = GameObject.FindObjectOfType<MusicManagerScript> ();
		musicManager.ChangeVolume (musicVol);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
