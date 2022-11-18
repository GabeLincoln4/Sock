using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _winMessage;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Screen Border")
        {
            Debug.Log("You lose");
        }

        if (col.gameObject.name == "Foot")
        {
            Debug.Log("You win");
        }

        PauseGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
