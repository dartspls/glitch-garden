﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedDefender;
	private Button[] buttonArray;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().color = Color.black;
		buttonArray = GameObject.FindObjectsOfType<Button> ();
	}

	void OnMouseDown() {
		foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer> ().color = Color.black;
		}
		GetComponent<SpriteRenderer> ().color = Color.white;
		selectedDefender = defenderPrefab;
	}
}
