using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//clase que genera 4 asteroides en cada extremo de la pantalla

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

        //float[,] positionsArray = new float[4, 4] { { 0f, 0.1f, 0f, 1f }, { 0f, 1f, 0f, 0.1f }, { 0.9f, 1f, 0f, 1f }, { 0f, 1f, 0f, 0.1f } };

        float[][] positionsArray;
        positionsArray = new float[4][];
        positionsArray[0] = new float[] { 0f, 0.1f, 0f, 1f }; //izquierda
        positionsArray[1] = new float[] { 0f, 1f, 0f, 0.1f }; //abajo
        positionsArray[2] = new float[] { 0.9f, 1f, 0f, 1f }; //derecha
        positionsArray[3] = new float[] { 0f, 1f, 0.9f, 1f }; //arriba

        while (iterator < MaxAsteroidNumber)
        {
            SpawnRandomObject(positionsArray[iterator]);
            iterator++;
        }
    }

    void SpawnRandomObject(float[] position)
    {
        Vector3 randomPosition = GetRandomViewportPosition(position[0], position[1], position[2], position[3]);
        Vector3 spawnPosition = mainCamera.ViewportToWorldPoint(randomPosition);

        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }

    Vector3 GetRandomViewportPosition(float minX, float maxX, float minY, float maxY)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector3(randomX, randomY, mainCamera.nearClipPlane + spawnRadius);
    }
}