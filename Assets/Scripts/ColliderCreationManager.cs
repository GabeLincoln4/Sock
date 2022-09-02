using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCreationManager : MonoBehaviour
{
    public BoxCollider2D CreateAndPlaceBoxCollider(float height, float offset, GameObject gameObject, string offsetDirection)
    {
        BoxCollider2D box;
        List<float> widthList = CalculateWidthFromDirection(offsetDirection);

        Vector2 newBoxSize = new Vector2(widthList[0], height);
        Vector2 newBoxOffset = new Vector2(widthList[1], offset);
        
        box = gameObject.AddComponent<BoxCollider2D>();
        box.size = newBoxSize;
        box.offset = newBoxOffset;

        return box;
    }

    private List<float> CalculateWidthFromDirection(string direction)
    {
        List<float> widthMeasurementsList = new List<float>();
        float sizeWidth = 0f;
        float offsetWidth = 0f;

        if (direction == "vertical")
        {
            sizeWidth = 0.64f;
            offsetWidth = 0f;
        }
        else
        {
            sizeWidth = 0.16f;
            offsetWidth = 0f;
        }

        widthMeasurementsList.Add(sizeWidth);
        widthMeasurementsList.Add(offsetWidth);

        return widthMeasurementsList;
    }
}