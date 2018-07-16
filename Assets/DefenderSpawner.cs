using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	Camera mainCam;
	GameObject defenderParent;
	
	void Start () {
		mainCam = Camera.main;
		defenderParent = GameObject.Find ("Defenders");
		if (!defenderParent) {
			defenderParent = new GameObject ("Defenders");
		}
	}
	
	void OnMouseDown() {
		if(Button.selectedDefender != null)
		{
			Vector2 rawPos = PixelsToWorldCoordinate ();
			Vector2 roundedPos = SnapToGrid (rawPos);
			GameObject spawnedDefender = Instantiate (Button.selectedDefender, roundedPos, Quaternion.identity);
			spawnedDefender.transform.parent = defenderParent.transform;
		}
		//print (SnapToGrid(PixelsToWorldCoordinate()));
	}
	Vector2 PixelsToWorldCoordinate(){
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float camDist = 10f;
		Vector3 worldPosCalc = new Vector3 (mouseX, mouseY, camDist);
		Vector2 rawWorldPos = mainCam.ScreenToWorldPoint (worldPosCalc);
		return rawWorldPos;
	}
	Vector2 SnapToGrid(Vector2 rawWorldPos){
		float gridX = Mathf.Round (rawWorldPos.x);
		float gridY = Mathf.Round (rawWorldPos.y);
		Vector2 gridWorldPos = new Vector2 (gridX, gridY);
		return gridWorldPos;
	}
}
