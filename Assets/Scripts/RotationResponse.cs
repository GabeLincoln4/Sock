using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationResponse : MonoBehaviour
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
