using UnityEngine;

public class Trigger : MonoBehaviour
{
    ITriggerable currentTriggerable;   
    public void OnTriggerEnter2D(Collider2D col)
    {
        currentTriggerable = col.GetComponent<ITriggerable>();
        currentTriggerable.Trigger();
    }
}
