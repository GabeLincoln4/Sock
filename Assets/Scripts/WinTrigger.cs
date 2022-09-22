using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField ]private GameObject _winMessage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You win");
        PauseGame();
        Instantiate(_winMessage);
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
