using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AttackerScript))]
public class LizardScript : MonoBehaviour {

	Animator m_Anim;
	AttackerScript attacker;
	// Use this for initialization
	void Start () {
		m_Anim = gameObject.GetComponent<Animator> ();
		attacker = gameObject.GetComponent<AttackerScript> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D col){
		GameObject collidedObject = col.gameObject;
		if (!collidedObject.GetComponent<DefenderScript> ()) {
			return;
		} else if (collidedObject.GetComponent<DefenderScript> ()) {
			m_Anim.SetBool ("IsAttacking", true);
			attacker.Attack (collidedObject);
		}
	}
}
