using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetController : MonoBehaviour
{
    private float CalculateOffsetOnSizeChange(float renderedSizeYAxis, float collisionSizeYAxis)
    {
        float scaledDownValue = 10f;
        float offsetYAxis;
        offsetYAxis = ((renderedSizeYAxis / scaledDownValue) - collisionSizeYAxis) / 2;

        return offsetYAxis;
    }
}