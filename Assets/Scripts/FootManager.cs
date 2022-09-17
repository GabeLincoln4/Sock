using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootManager : MonoBehaviour
{
    
    [SerializeField] private GameObject _foot;
    private Vector3 _direction = new Vector3(0, 1, 0);
    [SerializeField] private float _movementSpeed;
    
    void Awake()
    {
        _foot.AddComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        _foot.transform.Translate(_direction * _movementSpeed * Time.deltaTime);
    }
}
