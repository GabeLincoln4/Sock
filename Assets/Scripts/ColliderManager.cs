using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    [SerializeField] private GameObject _targetGameObject;
    [SerializeField] private GameObject _currentGameObject;

    private OffsetController _offsetController;
    private float _offsetHeight = 0f;

    void Awake()
    {
        float placementYAxis = _targetGameObject.GetComponent<Renderer>().bounds.size.y;
        _offsetController = _currentGameObject.AddComponent<OffsetController>();

        _offsetController.CalculateOffsetHeight(placementYAxis, .11f);
    }
}
