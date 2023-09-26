using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTwoAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public void SpawnAsteroids()
        {
        Debug.Log("Method Called");

        Vector3 spawnPosition = transform.position;
        Vector3 offset = new Vector3(0.5f, 0.5f, 0f); // Offset to spawn two new asteroids around the destroyed one

        // Instantiate two new asteroids with an offset from the destroyed one
        Instantiate(asteroidPrefab, spawnPosition + offset, Quaternion.identity);
        Instantiate(asteroidPrefab, spawnPosition - offset, Quaternion.identity);

    }

   
}
