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
    public float x;

    [SerializeField]
    public float y;
    
    [SerializeField]
    private int size;
    private Vector2[] _edges;
    private Transform _rotation;
    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;
    private EdgeCollider2D _sockCollider;


    void Awake()
    {
        var sockCollider = _sockCollider;
        sockCollider = _sock.AddComponent<EdgeCollider2D>();
        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _rotation = _sock.GetComponent<Transform>();
        // sockCollider.points = ModifyCollider(_sockCollider, _edges);
    }

    void Start()
    {
        var sock = _sock;
        var edges = _edges;
        // _colliderManager.AdjustEdgeCollider2D(edges, sock, x, y);
    }

    void Update()
    {
        var rotation = _rotation;
        
        _rotationResponse.RotateCounterclockwiseOnRightClick(rotation);
        _rotationResponse.RotateClockwiseOnLeftClick(rotation);  
    }

    public Vector2[] ModifyCollider(EdgeCollider2D edgeBorder, Vector2[] vertices)
    {

        vertices = edgeBorder.points;
        vertices[0] = new Vector2(-.32f, 0f);
        vertices[1] = new Vector2(.18f, 0f);
        return vertices;
    }
}