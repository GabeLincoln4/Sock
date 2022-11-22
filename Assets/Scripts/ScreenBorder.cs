using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBorder : MonoBehaviour, ITriggerable
{
    private StateController _stateController;

    void Awake()
    {
        _stateController = gameObject.AddComponent<StateController>();
    }

    public void Trigger()
    {
        Debug.Log("You Lose");
        _stateController.PauseGame();
    }
}