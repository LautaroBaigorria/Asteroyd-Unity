using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFourAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    SpawnSingleAsteroidScript asteroidScript;
    private void Start()
    {
        asteroidScript = GameObject.FindGameObjectWithTag("SingleAsteroid").GetComponent<SpawnSingleAsteroidScript>();
    }
    public void SpawnAsteroids()
        {
        Debug.Log("Method Called");

        Vector3 spawnPosition = transform.position;

        for (int i = 0; i < 4; i++)
        {
            asteroidScript.SpawnSingleAsteroid(spawnPosition, asteroidPrefab);
        }
        

    }
    

}
