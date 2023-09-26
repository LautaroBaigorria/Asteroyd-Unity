using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI points;
    
    // Update is called once per frame
    void Update()
    {
        points.text = GameManager.instance.TotalPoints.ToString();
    }
}
