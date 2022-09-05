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
            RotateAction(rotation, -_rotateSpeed);
        }
    }

    public void RotateCounterclockwise(Transform rotation)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            RotateAction(rotation, _rotateSpeed);
        }
    }

    public void RotateClockwiseOnLeftClick(Transform rotation)
    {
        if (Input.GetButton("Fire1"))
        {
            RotateAction(rotation, _rotateSpeed);
            Debug.Log("Left Clicked");
        }
    }

    public void RotateCounterclockwiseOnRightClick(Transform rotation)
    {
        if (Input.GetButton("Fire2"))
        {
            RotateAction(rotation, -_rotateSpeed);
            Debug.Log("Right Clicked");
        }
    }

    public void RotateAction(Transform rotation, float direction)
    {
        rotation.Rotate(Vector3.forward, direction * Time.deltaTime);
    }
}