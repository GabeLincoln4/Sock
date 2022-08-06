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

    

    void Start()
    {
        if (Rotation)
        {
            spin = new Rotate();

            spin.Rotation();
        }
        sock.AddComponent<EdgeCollider2D>();

        edges = sock.GetComponent<EdgeCollider2D>().points;
        colliderPoints = edges;
        colliderPoints[5] = new Vector2(x, y);
        edges = colliderPoints;

        Debug.Log(edges);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
