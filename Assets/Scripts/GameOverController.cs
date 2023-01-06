using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;
    public Button buttonQuit;

    private void Awake()
    {
        buttonRestart.onClick.AddListener(ReloadScene);
        buttonQuit.onClick.AddListener(Quit);
    }

    private void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerDied() 
    {
        gameObject.SetActive(true);
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
   
}
