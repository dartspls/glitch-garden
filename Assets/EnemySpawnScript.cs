using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour 
{
	public GameObject[] enemyPrefabs;

	

	private void Start()
	{
		
	}

	private void Update()
	{
		int monsterToSpawn = Random.Range(0, enemyPrefabs.Length);
		if(IsTimetoSpawn(enemyPrefabs[monsterToSpawn]))
		{
			Spawn(enemyPrefabs[monsterToSpawn]);
		}
	}

	void Spawn(GameObject attackerPrefab)
	{
		Instantiate(attackerPrefab, transform.position, Quaternion.identity);
	}

	private bool IsTimetoSpawn(GameObject attacker)
	{
		float spawnDelay = attacker.GetComponent<AttackerScript>().seenEverySeconds;
		float spawnsPerSec = 1 / spawnDelay;

		if(Time.deltaTime > spawnDelay)
		{
			Debug.LogWarning("Spawn rate capped by frame rate");
		}

		float threshold = spawnsPerSec * Time.deltaTime / 5;

		if(Random.value < threshold)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
