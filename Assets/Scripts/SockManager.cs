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

    private void Awake()
    {
        _rotationResponse = new RotationResponse();
    }

    void Start()
    {
        sock.AddComponent<EdgeCollider2D>();
        sock.AddComponent<Transform>();
        _rotation = sock.GetComponent<Transform>();
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

internal class RotationResponse : MonoBehaviour
    {

        [SerializeField] private float _rotateSpeed = 50;    

        public void RotateClockwise(Transform rotation)
        {
            if (Input.GetKey(KeyCode.E))
            {
                rotation.Rotate(Vector3.forward, -_rotateSpeed * Time.deltaTime);
            }
        }

        public void RotateCounterclockwise(Transform rotation)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                rotation.Rotate(Vector3.forward, _rotateSpeed * Time.deltaTime);
            }  
        }
    }
