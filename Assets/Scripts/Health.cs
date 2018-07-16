using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	public float hitPoints = 100;
	AttackerScript attacker;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (hitPoints <= 0) {
			Destroy (gameObject);
		}
	}

	public void DealDamage(float damage){
		hitPoints = hitPoints - damage;
	}
}
