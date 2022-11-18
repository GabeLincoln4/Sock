using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour, ITriggerable
{
    // [SerializeField] private GameObject _winMessage;
    
    public void Trigger()
    {
        Debug.Log("You Win!");
    }
}
