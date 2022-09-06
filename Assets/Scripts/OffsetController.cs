using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetController : MonoBehaviour
{
    private float scaledDownValue = 10f;
    public float CalculateOffsetHeight(float renderedSizeYAxis, float collisionSizeYAxis)
    {
        float offsetYAxis;

        offsetYAxis = ((renderedSizeYAxis / scaledDownValue) - collisionSizeYAxis) / 2;

        return offsetYAxis;
    }

    public float CalculateOffsetWidth(float renderedSizeXAxis, float collisionSizeXAxis)
    {
        float offsetXAxis;

        offsetXAxis = ((renderedSizeXAxis / scaledDownValue) - collisionSizeXAxis) / 2;

        return offsetXAxis;
    }
}