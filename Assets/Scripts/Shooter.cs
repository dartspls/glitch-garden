using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public Rigidbody2D projectilePrefab;
	private GameObject projParent;
	// Use this for initialization
	void Start () {
		projParent = GameObject.Find ("Projectiles");
		if (projParent == null) {
			projParent = new GameObject ("Projectiles");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void ShootProjectile (){
		Rigidbody2D generatedProj = Instantiate (projectilePrefab, transform.position, Quaternion.identity);
		generatedProj.transform.parent = projParent.transform;
	}
}
