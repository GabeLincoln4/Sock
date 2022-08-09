using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField]
    private bool Rotation;

    [SerializeField]
    private GameObject _sock;
    
    [SerializeField]
    private float x;

    [SerializeField]
    private float y;
    
    [SerializeField]
    private int size;
    private Vector2[] _edges;
    private Transform _rotation;

    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;

    void Awake()
    {
        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _rotation = _sock.GetComponent<Transform>();
        Debug.Log(_rotationResponse);

        _colliderManager = _sock.AddComponent<EdgeColliderManager>();
    }

    void Start()
    {
        var sock = _sock;
        var edges = _edges;
        _colliderManager.AdjustEdgeCollider2D(edges, sock, x, y);
        Debug.Log(_edges);
    }

    void Update()
    {
        var rotation = _rotation;
        
        _rotationResponse.RotateCounterclockwiseOnRightClick(rotation);
        _rotationResponse.RotateClockwiseOnLeftClick(rotation);  
    }

    
}