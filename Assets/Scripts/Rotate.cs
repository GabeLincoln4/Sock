using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate
{
    private float speed = 50f;

    public void Rotation()
    {
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);

        Debug.Log("Rotate script reporting for duty");
    }
}
