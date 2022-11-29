using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootManager : MonoBehaviour
{
    [SerializeField] private GameObject _foot;
    [SerializeField] private float _movementSpeed;
    private Vector3 _direction = new Vector3(0, 1, 0);
    private BoundaryController _boundaryController;    

    void Awake()
    {
        _foot.AddComponent<BoxCollider2D>();
        _boundaryController = _foot.AddComponent<BoundaryController>();
    }

    void Update()
    {
        _direction = _boundaryController.SetFootBoundaries(_foot, _direction);
        _foot.transform.Translate(_direction * _movementSpeed * Time.deltaTime);  
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You Win!");
    }
}
