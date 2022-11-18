using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBorder : MonoBehaviour, ITriggerable
{
    public void Trigger()
    {
        Debug.Log("You lose");
    }
}
