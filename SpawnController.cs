using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;  // Reference to the prefab you want to spawn
    public int numberOfPrefabs = 10;   // Number of prefabs to spawn
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f);  // The size of the area where prefabs will be spawned

    private void Start()
    {
        SpawnPrefabs();
    }

    private void SpawnPrefabs()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                Random.Range(0.0f, spawnAreaSize.x / 2),
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

            Instantiate(prefabToSpawn, spawnPosition, spawnRotation);
        }
    }
}
