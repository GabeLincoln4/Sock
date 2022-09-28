using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField ]private GameObject _winMessage;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Sock"))
        {
            Debug.Log("You win");
            PauseGame();
            Instantiate(_winMessage);
        }

        if (col.gameObject.CompareTag("Screen Border"))
        {
            Debug.Log("You Lose");
            PauseGame();
        }
        
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
