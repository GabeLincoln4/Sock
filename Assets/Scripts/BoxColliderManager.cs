using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderManager : MonoBehaviour
{
    private OffsetController _offsetController;

    public List<BoxCollider2D> CreateBoxCollider(GameObject gameObject, float boxColliderHeight)
    {
        _offsetController = gameObject.AddComponent<OffsetController>();
        float renderedSizeHeight = gameObject.GetComponent<Renderer>().bounds.size.y;
        float renderedSizeWidth = gameObject.GetComponent<Renderer>().bounds.size.x;
        List<BoxCollider2D> colliderList = new List<BoxCollider2D>();
        BoxCollider2D topBox;
        BoxCollider2D bottomBox;
        BoxCollider2D middleBox;
        float verticalColliderOffset = _offsetController.CalculateOffsetHeight(renderedSizeHeight, boxColliderHeight);
        //float horizontalColliderOffset = _offsetController.CalculateOffsetWidth(renderedSizeWidth, boxColliderWidth);
        Vector2 newBoxSize = new Vector2(0.64f, boxColliderHeight);
        Vector2 newMiddleBoxSize = new Vector2(0.16f, boxColliderHeight);

        
        Vector2 newBoxOffset = new Vector2(0f, verticalColliderOffset);
        Vector2 newBottomBoxOffset = new Vector2(0f, -verticalColliderOffset);
        Vector2 newMiddleBoxOffset = new Vector2(0.24f, 0f);
        
        topBox = gameObject.AddComponent<BoxCollider2D>();
        bottomBox = gameObject.AddComponent<BoxCollider2D>();
        middleBox = gameObject.AddComponent<BoxCollider2D>();

        Debug.Log(topBox.offset);
        topBox.size = newBoxSize;
        bottomBox.size = newBoxSize;
        middleBox.size = newMiddleBoxSize;
        topBox.offset = newBoxOffset;
        bottomBox.offset = newBottomBoxOffset;
        middleBox.offset = newMiddleBoxOffset;
        Debug.Log(topBox.bounds.center.GetType());
        colliderList.Add(bottomBox);
        colliderList.Add(topBox);
        
        Debug.Log(gameObject.GetComponent<Renderer>().bounds.size);

        return colliderList;
    }
}
