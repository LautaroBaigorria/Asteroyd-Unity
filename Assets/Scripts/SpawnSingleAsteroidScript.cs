using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSingleAsteroidScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSingleAsteroid(Vector3 spawnPosition, GameObject asteroidPrefab)
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        Vector3 offset = new(randomX, randomY, 0f);
        Instantiate(asteroidPrefab, spawnPosition + offset, Quaternion.identity);
    }
}
