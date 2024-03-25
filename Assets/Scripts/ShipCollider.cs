using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipCollider : MonoBehaviour
    

{
    ShipOne shipOne;
    Lives livesScript;
    private Vector3 initialPos;
    private Quaternion initialRotation;
    //GameManager gameManager;


    private void Start()
    {
        shipOne = GetComponent<ShipOne>();
        initialPos = shipOne.transform.position;
        initialRotation = shipOne.transform.rotation;
        //gameManager = GetComponent<GameManager>();
        livesScript = GameObject.FindGameObjectWithTag("livesScript").GetComponent<Lives>();
        
    }

    private void OnTriggerEnter2D(Collider2D asteroid)
    {
        if (asteroid.CompareTag("LargeAsteroid") || asteroid.CompareTag("MediumAsteroid") || asteroid.CompareTag("SmallAsteroid"))
        {
            Debug.Log("Hit detected");
            Destroy(asteroid.gameObject);
            if (asteroid.CompareTag("LargeAsteroid"))
            {
                asteroid.GetComponent<SpawnTwoAsteroids>().SpawnAsteroids();
            }
            else if (asteroid.CompareTag("MediumAsteroid"))
            {
                asteroid.GetComponent<SpawnFourAsteroids>().SpawnAsteroids();
            }
            //this.gameObject.SetActive(false);
            // resetear la posicion de la nave y setactive
            
            livesScript.LoseLife();

            ResetPositionAfterHit();
            //this.gameObject.SetActive(true);

        }
        

    }

    public void ResetPositionAfterHit()
    {

        shipOne.gameObject.SetActive(false);
        shipOne.transform.SetPositionAndRotation(initialPos, initialRotation);
        shipOne.gameObject.SetActive(true);
        StartCoroutine(InvulnerableforNSeconds());
        
        //this.enabled = false;

    }
    IEnumerator InvulnerableforNSeconds(int nSeconds = 2) 
    {
        shipOne.GetComponent<SpriteRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        shipOne.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(nSeconds);
        shipOne.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
        shipOne.GetComponent<BoxCollider2D>().enabled = true;
    }

    
    
}
