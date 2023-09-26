using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletCollider : MonoBehaviour

{
    public int LargeAsteroidPoint = 50;
    public int MediumAsteroidPoint = 25;
    public int SmallAsteroidPoint = 10;

    

    private void OnTriggerEnter2D(Collider2D asteroid)
    //private void OnCollisionEnter2D(Collision2D asteroid)

    {
        if (asteroid.gameObject.CompareTag("LargeAsteroid"))
        {
            Debug.Log("Hit detected");
            GameObject collidedAsteroid = asteroid.gameObject;
            collidedAsteroid.GetComponent<SpawnTwoAsteroids>().SpawnAsteroids();
            Destroy(collidedAsteroid);
            Destroy(gameObject);
            GameManager.instance.AddPoints(LargeAsteroidPoint);
        }

        if (asteroid.gameObject.CompareTag("MediumAsteroid"))
        {
            Debug.Log("Hit detected");
            GameObject collidedAsteroid = asteroid.gameObject;
            collidedAsteroid.GetComponent<SpawnFourAsteroids>().SpawnAsteroids();
            Destroy(collidedAsteroid);
            Destroy(gameObject);
            GameManager.instance.AddPoints(MediumAsteroidPoint);
        }

        if (asteroid.gameObject.CompareTag("SmallAsteroid"))
        {
            Debug.Log("Hit detected");
            GameObject collidedAsteroid = asteroid.gameObject;
            Destroy(collidedAsteroid);
            Destroy(gameObject);
            GameManager.instance.AddPoints(SmallAsteroidPoint);
        }
    }
}
