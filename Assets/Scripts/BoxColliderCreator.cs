using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderCreator : MonoBehaviour
{
    public BoxCollider2D CreateBoxCollider(GameObject gameObject)
    {
        BoxCollider2D boxEdges;
        float verticalColliderOffset = .15f;
        Vector2 newBoxSize = new Vector2(0.64f, 0.13f);
        Vector2 newBoxOffset = new Vector2(0f, verticalColliderOffset);
        // Vector3 topBoxLocation = boxLocation.position;
        // topBoxLocation.y = topBoxLocation.y + newBoxSize.x;
        // Debug.Log(topBoxLocation);
        // boxLocation.position = topBoxLocation;

        boxEdges = gameObject.AddComponent<BoxCollider2D>();
        Debug.Log(boxEdges.offset);
        boxEdges.size = newBoxSize;
        boxEdges.offset = newBoxOffset;
        Debug.Log(boxEdges.bounds.center.GetType());

        return boxEdges;
    }
}
