using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public Vector3 SetFootBoundaries(GameObject gameObject, Vector3 direction)
    {
        Vector3 objectPosition = gameObject.transform.position;
        float heightBoundary = 3.5f;

        if (objectPosition.y >= heightBoundary)
        {
            direction = new Vector3(0, -1, 0);
        }

        if (objectPosition.y <= -heightBoundary)
        {
            direction = new Vector3(0, 1, 0);
        } 

        return direction;
    }
}
