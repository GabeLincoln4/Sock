using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate
{
    public Transform rotationObject;
    public float rotateSpeed = 50f;

    public void Rotation()
    {
        //rotationObject = rotationObject.GetComponent<Transform>();

        //if (Input.GetKey(KeyCode.Q))
        //{
            //rotationObject.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotateSpeed);
        //}

        Debug.Log("Rotate script reporting for duty");
    }
}
