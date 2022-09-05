using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingResponse : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 2.5f;

    public void ScalingResponseOnInput(Transform scale, Vector3 currentHeight)
    {
        if (Input.GetKey(KeyCode.T))
        {
            ScaleAction(scale, _scaleSpeed, currentHeight);
        }
    }

    public void ScaleAction(Transform scale, float speed, Vector3 currentHeight)
    {
        scale.localScale += Vector3.up * Time.deltaTime * speed;
        currentHeight += Vector3.up * Time.deltaTime * speed;
    }

    public float changeHeight(float height)
    {
        return height * Time.deltaTime;
    }
}
