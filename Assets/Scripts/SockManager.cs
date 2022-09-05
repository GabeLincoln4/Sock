using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField] private GameObject _sock;
    [SerializeField] private string sockOpeningSize;
    private Vector2[] _edges;
    private Transform _transform;
    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;
    private BoxColliderManager _boxCollider;
    private ScalingResponse _scaleResponse;
    private float _middleBoxHeight = .1f;
    private Vector3 boundsOfSock;


    void Awake()
    {
        boundsOfSock = _sock.GetComponent<Renderer>().bounds.size;
        _colliderManager = _sock.AddComponent<EdgeColliderManager>();

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
            _boxCollider.CreateBoxCollider(_sock, .13f);
            _boxCollider.CreateMiddleBoxCollider(_sock, _middleBoxHeight);
        }

        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _scaleResponse = _sock.AddComponent<ScalingResponse>();
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
        
        _rotationResponse.RotateCounterclockwiseOnRightClick(transform);
        _rotationResponse.RotateClockwiseOnLeftClick(transform);
        _scaleResponse.ScalingResponseOnInput(transform, boundsOfSock);
        Debug.Log(_sock.GetComponent<Renderer>().bounds.size);
    }  
}
