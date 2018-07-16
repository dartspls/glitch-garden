using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class AttackerScript : MonoBehaviour {

	private float currentSpeed;

	private GameObject curTarget;
	private Animator m_Anim;

	// Use this for initialization
	void Start () {
		m_Anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (m_Anim.GetBool ("IsAttacking") == true && !curTarget) {
			m_Anim.SetBool ("IsAttacking", false);
		}

		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("attacker collided with " + collider);
	}

	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget (float damage) {

		if (curTarget.GetComponent<Health> ()) {
			Health hp = curTarget.GetComponent<Health> ();
			hp.DealDamage (damage);
		} 
		//Debug.Log("Attacked for " + damage + " damage");
	}
	public void Attack(GameObject collidedObject){
		curTarget = collidedObject;
		//healthScript = curTarget.GetComponent<Health> ();

	}
}
