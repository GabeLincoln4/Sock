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
    private Vector2[] colliderPoints;
    private Vector2[] _edges;
    private Transform _rotation;

    private RotationResponse _rotationResponse;

    void Awake()
    {
        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _rotation = _sock.GetComponent<Transform>();
        Debug.Log(_rotationResponse);
    }

    void Start()
    {
        var sock = _sock;
        var edges = _edges;
        _sock.AddComponent<EdgeCollider2D>();
        _edges = _sock.GetComponent<EdgeCollider2D>().points;
        colliderPoints = _edges;
        colliderPoints[5] = new Vector2(x, y);
        _edges = colliderPoints;

        Debug.Log(_edges);
    }

    void Update()
    {
        var rotation = _rotation;
        
        _rotationResponse.RotateCounterclockwiseOnRightClick(rotation);
        _rotationResponse.RotateClockwiseOnLeftClick(rotation);  
    }

    public void AdjustEdgeCollider2D(Vector2[] edges)
    {

    }
}