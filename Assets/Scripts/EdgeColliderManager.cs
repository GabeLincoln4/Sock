using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    public void AdjustEdgeCollider2D(Vector2[] edges, GameObject gameObject, float x, float y)
    {
        gameObject.AddComponent<EdgeCollider2D>();
        edges = gameObject.GetComponent<EdgeCollider2D>().points;
        edges[0] = new Vector2(x, y);
    }
}
