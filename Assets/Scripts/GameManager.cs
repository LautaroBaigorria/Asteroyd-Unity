using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public int TotalPoints { get { return totalPoints; }  }
    private int totalPoints;
    
    private void Start()
    {
        //hud1 = GameObject.FindGameObjectWithTag("Hud").GetComponent<HUD>();
    }


    public void AddPoints(int PointsToAdd) 
    {
        totalPoints += PointsToAdd;
        Debug.Log(totalPoints);
        //hud1.UpdatePoints(totalPoints);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("More than one GameManager instance");
        }
    }

    //public void LoseLife() 
    //{
    //    lives -= 1;
    //    Debug.Log("lives left " + lives);


    //    if (lives ==0 ) 
    //    {
    //        Debug.Log("game over!");
    //        SceneManager.LoadScene(0);

    //    }
    //}

   

    
}



