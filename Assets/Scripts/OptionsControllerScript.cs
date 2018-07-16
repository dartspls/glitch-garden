using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsControllerScript : MonoBehaviour {

	public Slider volumeSlider, diffSlider;

	public LevelManagerScript levelManager;

	private MusicManagerScript musicManager;

	// Use this for initialization
	void Start () {
		volumeSlider.value = PlayerPrefManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefManager.GetDifficulty ();
		musicManager = GameObject.FindObjectOfType<MusicManagerScript> ();
		Debug.Log (musicManager);
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	}
	public void SaveAndExit() {
		PlayerPrefManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefManager.SetDifficulty (diffSlider.value);
		levelManager.LoadLevel ("01a Start Menu");
	}
	public void SetDefaultOptions () {
		volumeSlider.value = 0.5f;
		diffSlider.value = 2f;
	}
	public void RevertOptions () {
		volumeSlider.value = PlayerPrefManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefManager.GetDifficulty ();
	}
}
