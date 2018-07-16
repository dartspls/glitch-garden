using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public float speed = 3f;
	public float damage = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
	void OnTriggerEnter2D (Collider2D col){
		AttackerScript attacker = col.GetComponent<AttackerScript> ();
		Health health = col.GetComponent<Health> ();
		if (health && attacker) {
			health.DealDamage (damage);
			Destroy (gameObject);
		}
		//Debug.Log ("Projectile collided with: " + col);
	}
}
