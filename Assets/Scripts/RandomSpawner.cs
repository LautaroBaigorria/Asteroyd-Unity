using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class RandomSpawner : MonoBehaviour
//{
//    public GameObject asteroidPrefab;
//    public int MaxAsteroidNumber = 4;
//    public int iterator = 0;
//    // Update is called once per frame
//    void Update()
//    {
        
//        while ( iterator <= MaxAsteroidNumber)
//        { 
//            Vector2 randomSpawnPosition = new Vector2 (Random.value, Random.value);
//            Instantiate(asteroidPrefab,randomSpawnPosition,Quaternion.identity);
//            iterator += 1;
//        }
//    }
//}


public class RandomSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;

    private Camera mainCamera;
    //private float timer;

    public int iterator = 0;
    public int MaxAsteroidNumber = 4;

    void Start()
    {
        mainCamera = Camera.main;
        //timer = spawnRate;
    }

    void Update()
    {

        while (iterator < MaxAsteroidNumber)
        {
            SpawnRandomObject();
            iterator++;
        }
    }

    void SpawnRandomObject()
    {
        Vector3 randomPosition = GetRandomViewportPosition();
        Vector3 spawnPosition = mainCamera.ViewportToWorldPoint(randomPosition);

        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }

    Vector3 GetRandomViewportPosition()
    {
        float randomX = Random.Range(0f, 1f);
        float randomY = Random.Range(0f, 1f);

        return new Vector3(randomX, randomY, mainCamera.nearClipPlane + spawnRadius);
    }
}