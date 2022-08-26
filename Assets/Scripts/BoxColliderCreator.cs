using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderCreator : MonoBehaviour
{
    public BoxCollider2D CreateBoxCollider(GameObject gameObject)
    {
        BoxCollider2D boxEdges;
        Vector2 newBoxSize = new Vector2(0.64f, 0.13f);

        boxEdges = gameObject.AddComponent<BoxCollider2D>();
        boxEdges.size = newBoxSize;

        return boxEdges;
    }
}
