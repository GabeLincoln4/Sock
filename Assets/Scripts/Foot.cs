using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    private StateController _stateController;

    void Awake()
    {
        _stateController = gameObject.AddComponent<StateController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You Win!");
        _stateController.PauseGame();
    }
}
