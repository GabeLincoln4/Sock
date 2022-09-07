using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCreationManager : MonoBehaviour
{
    private OffsetController _offsetController;
    private Transform _invertedColliderVector;

    public BoxCollider2D CreateAndPlaceBoxCollider(float height, float offset, GameObject gameObject, string offsetDirection)
    {
        BoxCollider2D box;
        float localHeight;
        _invertedColliderVector = GetComponent<Transform>();
        List<float> widthList = CalculateWidthFromDirection(offsetDirection, gameObject, height);

        Vector2 newBoxSize = new Vector2(widthList[0], height);
        Vector2 newBoxOffset = new Vector2(widthList[1], widthList[2] * offset);
        
        box = gameObject.AddComponent<BoxCollider2D>();
        box.size = newBoxSize;
        box.offset = newBoxOffset;

        return box;
    }

    private List<float> CalculateWidthFromDirection(string direction, GameObject gameObject, float height)
    {
        _offsetController = GetComponent<OffsetController>();
        float renderedSizeHeight = gameObject.GetComponent<Renderer>().bounds.size.y;

        List<float> widthMeasurementsList = new List<float>();
        float sizeWidth = 0f;
        float offsetWidth = 0f;
        float offsetHeight = 0f;

        if (direction == "vertical")
        {
            sizeWidth = 0.64f;
            offsetWidth = 0f;
            offsetHeight = _offsetController.CalculateOffsetHeight(renderedSizeHeight, height);
        }
        else
        {
            sizeWidth = 0.16f;
            offsetWidth = .238f;
            offsetHeight = 0f;
        }

        widthMeasurementsList.Add(sizeWidth);
        widthMeasurementsList.Add(offsetWidth);
        widthMeasurementsList.Add(offsetHeight);

        return widthMeasurementsList;
    }
}