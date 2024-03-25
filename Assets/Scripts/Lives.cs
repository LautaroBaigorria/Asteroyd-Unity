using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{

    private int lives = 3;
    public GameObject[] lifeSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseLife()
    {
        lives--;
        if (lives < 1)
        {
            Destroy(lifeSprites[0]);
            Debug.Log("game over!");
            SceneManager.LoadScene(0);
        }
        if (lives < 2) { Destroy(lifeSprites[1]); }
        if (lives < 3) { Destroy(lifeSprites[2]); }
    }

    public bool GainLife()
    {
        if (lives == 3)
        {
            return false;
        }


        lives += 1;
        return true;
    }
}
