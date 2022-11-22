using UnityEngine;

public class Sock : MonoBehaviour
{
    private Movement _movement;
    private RotationResponse _rotationResponse;
    private Trigger _trigger;

    void Awake()
    {
        _movement = gameObject.AddComponent<Movement>();
        _rotationResponse = gameObject.AddComponent<RotationResponse>();
        _trigger = gameObject.AddComponent<Trigger>();
    }
}
