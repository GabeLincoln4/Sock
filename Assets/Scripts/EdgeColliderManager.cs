using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    public Vector2[] ModifyCollider(GameObject gameObject, float x, float y, float xx, float yy)
    {
        Vector2[] edgeBorder;
        EdgeCollider2D collider;

        collider = gameObject.AddComponent<EdgeCollider2D>();
        edgeBorder = collider.points;
        edgeBorder[0] = new Vector2(x, y);
        edgeBorder[1] = new Vector2(xx, yy);
        collider.points = edgeBorder;
        return edgeBorder;
    }
}
