using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetController : MonoBehaviour
{
    public float CalculateOffset(float renderedSizeYAxis, float collisionSizeYAxis)
    {
        float scaledDownValue = 10f;
        float offsetYAxis;
        offsetYAxis = ((renderedSizeYAxis / scaledDownValue) - collisionSizeYAxis) / 2;

        return offsetYAxis;
    }
}