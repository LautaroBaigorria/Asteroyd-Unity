using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI points;
    public GameObject[] lives;
    //GameManager gameManager;

    private void Start()
    {
        //gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = GameManager.instance.TotalPoints.ToString();


    }

    public void UpdatePoints(int totalPoints)
    {
        points.text = totalPoints.ToString();
    }
    public void SubtractLife(int index)
    {
        lives[index].SetActive(false);
    }
    public void AddLife(int index)
    {
        lives[index].SetActive(true);
    }

}
