using UnityEngine;

public class ComponentInitializer : MonoBehaviour
{
    private StateController _stateController;

    void Awake()
    {
        _stateController = gameObject.AddComponent<StateController>();
    }
}