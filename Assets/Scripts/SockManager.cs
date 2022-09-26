using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField] private GameObject _sock;
    [SerializeField] private string sockOpeningSize;
    [SerializeField] private bool _rotation;
    [SerializeField] private float _speed;
    private Vector2[] _edges;
    private Transform _transform;
    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;
    private BoxColliderManager _boxCollider;
    private ScalingResponse _scaleResponse;
    private float _middleBoxHeight = .1f;
    private Vector3 boundsOfSock;
    private Movement _movement;


    void Awake()
    {
        boundsOfSock = _sock.GetComponent<Renderer>().bounds.size;
        _colliderManager = _sock.AddComponent<EdgeColliderManager>();
        _movement = _sock.AddComponent<Movement>();
        _boxCollider = _sock.AddComponent<BoxColliderManager>();

        if (sockOpeningSize == "xl")
        {
            _boxCollider.CreateBoxCollider(_sock, .10f);
            _boxCollider.CreateMiddleBoxCollider(_sock, _middleBoxHeight);
        }

        if (sockOpeningSize == "large")
        {
            _boxCollider.CreateBoxCollider(_sock, .11f);
            _boxCollider.CreateMiddleBoxCollider(_sock, _middleBoxHeight);
        }
        
        if (sockOpeningSize == "medium")
        {
            _boxCollider.CreateBoxCollider(_sock, .12f);
            _boxCollider.CreateMiddleBoxCollider(_sock, _middleBoxHeight);
        }

        if (sockOpeningSize == "small")
        {
            Debug.Log("Size is small");
        }

        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _transform = _sock.GetComponent<Transform>();
    }

    void Start()
    {
        var sock = _sock;
        var edges = _edges;
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
