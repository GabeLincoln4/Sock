using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderCreator : MonoBehaviour
{
    public List<BoxCollider2D> CreateBoxCollider(GameObject gameObject)
    {
        float adjustedOffset;
        List<BoxCollider2D> colliderList = new List<BoxCollider2D>();
        BoxCollider2D topBox;
        BoxCollider2D bottomBox;
        float verticalColliderOffset = .135f;
        Vector2 newBoxSize = new Vector2(0.64f, 0.13f);

        
        Vector2 newBoxOffset = new Vector2(0f, verticalColliderOffset);
        Vector2 newBottomBoxOffset = new Vector2(0f, -verticalColliderOffset);
        
        topBox = gameObject.AddComponent<BoxCollider2D>();
        bottomBox = gameObject.AddComponent<BoxCollider2D>();
        Debug.Log(topBox.offset);
        topBox.size = newBoxSize;
        bottomBox.size = newBoxSize;
        topBox.offset = newBoxOffset;
        bottomBox.offset = newBottomBoxOffset;
        Debug.Log(topBox.bounds.center.GetType());
        colliderList.Add(bottomBox);
        colliderList.Add(topBox);
        
        Debug.Log(gameObject.GetComponent<Renderer>().bounds.size);

        return colliderList;
    }

    private void CalculateOffsetOnSizeChange(float offset, float size, float distanceFromEdge)
    {
        // float adjustedOffset;

        // adjustedOffset = distanceFromEdge / 2 + offset;

        // return adjustedOffset;
    }
}
