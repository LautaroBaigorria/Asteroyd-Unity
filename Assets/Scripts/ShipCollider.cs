using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D asteroid)
    {
        if (asteroid.CompareTag("LargeAsteroid") || asteroid.CompareTag("MediumAsteroid") || asteroid.CompareTag("SmallAsteroid"))
        {
            Debug.Log("Hit detected");
            Destroy(asteroid.gameObject);
            this.gameObject.SetActive(false);
        }
        

    }
}
