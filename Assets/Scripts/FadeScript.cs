﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {
	public float fadeInTime;
	private Image fadePanel;
	private Color curColour = Color.black;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			curColour.a -= alphaChange;
			fadePanel.color = curColour;
		} else {
			gameObject.SetActive (false);
		}
	}
}
