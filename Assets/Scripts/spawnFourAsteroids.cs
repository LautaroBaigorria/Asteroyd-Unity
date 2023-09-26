using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFourAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public void SpawnAsteroids()
        {
        Debug.Log("Method Called");

        Vector3 spawnPosition = transform.position;
        Vector3 offset = new Vector3(0.5f, 0.5f, 0f); // Offset to spawn two new asteroids around the destroyed one
        Vector3 offset2 = new Vector3(1.5f, 1.5f, 0f);
        // Instantiate two new asteroids with an offset from the destroyed one
        Instantiate(asteroidPrefab, spawnPosition + offset, Quaternion.identity);
        Instantiate(asteroidPrefab, spawnPosition - offset, Quaternion.identity);
        Instantiate(asteroidPrefab, spawnPosition + offset2 , Quaternion.identity);
        Instantiate(asteroidPrefab, spawnPosition - offset2, Quaternion.identity);


    }


}
