using UnityEngine;

public class LoseTrigger : MonoBehaviour, ITriggerable
{
    public void Trigger()
    {
        Debug.Log("You lose");
    }
}
