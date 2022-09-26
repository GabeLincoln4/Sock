using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField] private GameObject _sock;
    [SerializeField] private bool _rotation;
    [SerializeField] private float _speed;
    private Transform _transform;
    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;
    private BoxColliderManager _boxCollider;
    private Movement _movement;

    void Awake()
    {
        _movement = _sock.AddComponent<Movement>();
        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _transform = _sock.GetComponent<Transform>();
    }

    void Update()
    {
        var transform = _transform;
        
        if (_rotation)
        {
            _rotationResponse.RotateCounterclockwiseOnRightClick(transform);
            _rotationResponse.RotateClockwiseOnLeftClick(transform);
        }
    }  

    void FixedUpdate()
    {
        _movement.MoveVertically(_speed);
    }
}