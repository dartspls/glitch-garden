using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour 
{
	public GameObject[] enemyPrefabs;
	int tempInt = 0;

	private float lastSpawn = 0;
	public float spawnDelay = 5f;
	
	private void Update()
	{
		if(lastSpawn < Time.time)
		{
			lastSpawn = Time.time + spawnDelay;
			Spawn();
			Debug.Log("spawn call");
		}
	}

	void Spawn()
	{
        Debug.Log("start of spawn");
		int monsterID = Random.Range(0, 2);
		GameObject spawnedMonster = Instantiate(enemyPrefabs[monsterID], transform.position, Quaternion.identity);

        Debug.Log("end of spawn");
	}
}
