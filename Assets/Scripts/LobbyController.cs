using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class LobbyController : MonoBehaviour
{
    public Button buttonPlay;
    public Button buttonQuit;

    private void Awake()
    {
        buttonPlay.onClick.AddListener(PlayGame);
        buttonQuit.onClick.AddListener(QuitGame);

    }

    private void QuitGame()
    {
        EditorApplication.isPlaying = false;
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(1)   ;
    }
}
