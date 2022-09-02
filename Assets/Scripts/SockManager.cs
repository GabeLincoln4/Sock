using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SockManager : MonoBehaviour
{
    [SerializeField] private GameObject _sock;
    [SerializeField] private string sockOpeningSize;
    private Vector2[] _edges;
    private Transform _rotation;
    private RotationResponse _rotationResponse;
    private EdgeColliderManager _colliderManager;
    private BoxColliderManager _boxCollider;


    void Awake()
    {
        _colliderManager = _sock.AddComponent<EdgeColliderManager>();

        _boxCollider = _sock.AddComponent<BoxColliderManager>();

        if (sockOpeningSize == "xl")
        {
            _boxCollider.CreateBoxCollider(_sock, .10f);
        }

        if (sockOpeningSize == "large")
        {
            _boxCollider.CreateBoxCollider(_sock, .11f);
        }
        
        if (sockOpeningSize == "medium")
        {
            _boxCollider.CreateBoxCollider(_sock, .12f);
        }

        if (sockOpeningSize == "small")
        {
            _boxCollider.CreateBoxCollider(_sock, .13f);
        }

        _rotationResponse = _sock.AddComponent<RotationResponse>();
        _rotation = _sock.GetComponent<Transform>();
    }

    void Start()
    {
        var sock = _sock;
        var edges = _edges;
    }

    void Update()
    {
        var rotation = _rotation;
        
        _rotationResponse.RotateCounterclockwiseOnRightClick(rotation);
        _rotationResponse.RotateClockwiseOnLeftClick(rotation);
          
    }  
}
