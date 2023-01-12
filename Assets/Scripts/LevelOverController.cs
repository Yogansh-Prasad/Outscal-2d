using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    public GameObject gameobject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Level Completed by the Player:)");         
            
            LevelManager.Instance.MarkCurrentLevelComplete();

            gameobject.SetActive(true);

            


        }

    }

  
}
