using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI scoretext;

    private int score;


    private void Awake()
    {
        scoretext = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    { 
        score += increment;
        RefreshUI();
    }

    private void RefreshUI()
    {
        scoretext.text = "Score : " + score;
    }
}
