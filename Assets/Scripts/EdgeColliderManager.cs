using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    private Mesh colliderMesh;

    public void AdjustEdgeCollider2D(Vector2[] edges, GameObject gameObject, float x, float y)
    {
        gameObject.AddComponent<EdgeCollider2D>();
        colliderMesh = gameObject.GetComponent<EdgeCollider2D>().CreateMesh(true, true);
        edges = gameObject.GetComponent<EdgeCollider2D>().points;
        edges[0] = new Vector2(x, y);
    }
}
