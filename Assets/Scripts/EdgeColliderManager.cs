using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    private EdgeCollider2D _collider;
    public void ModifyEdgeCollider2D(EdgeCollider2D sockCollider)
    {
        sockCollider = GetComponent<EdgeCollider2D>();
        // edges = gameObject.GetComponent<EdgeCollider2D>().points;
        // edges[0] = new Vector2(x, y);
    }
}
