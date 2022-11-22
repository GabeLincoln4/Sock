using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour, ITriggerable
{
    private StateController _stateController;

    void Awake()
    {
        _stateController = gameObject.AddComponent<StateController>();
    }

    public void Trigger()
    {
        Debug.Log("You Win!");
        _stateController.PauseGame();
    }
}
