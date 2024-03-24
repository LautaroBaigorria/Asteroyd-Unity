using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public HUD hud1;
    public int TotalPoints { get { return totalPoints; }  }
    private int totalPoints;
    
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
}
