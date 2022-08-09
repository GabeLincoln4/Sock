using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField]
    private bool Rotation;

    [SerializeField]
    private GameObject sock;
    
    [SerializeField]
    private float x;

    [SerializeField]
    private float y;
    
    [SerializeField]
    private int size;
    private Vector2[] colliderPoints;
    private Vector2[] edges;
    private Rotate spin;
    private Transform _rotation;

    private RotationResponse _rotationResponse;

    void Awake()
    {
        _rotationResponse = sock.AddComponent<RotationResponse>();
        _rotation = sock.GetComponent<Transform>();
        Debug.Log(_rotationResponse);
    }

    void Start()
    {
        sock.AddComponent<EdgeCollider2D>();
        edges = sock.GetComponent<EdgeCollider2D>().points;
        colliderPoints = edges;
        colliderPoints[5] = new Vector2(x, y);
        edges = colliderPoints;

        Debug.Log(edges);
    }

    void Update()
    {
        var rotation = _rotation;
        
        _rotationResponse.RotateCounterclockwise(rotation);
        _rotationResponse.RotateClockwise(rotation);  
    }
}