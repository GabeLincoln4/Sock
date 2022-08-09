using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void AdjustEdgeCollider2D(Vector2[] edges, GameObject gameObject, float x, float y)
    {
        gameObject.AddComponent<EdgeCollider2D>();
        edges = gameObject.GetComponent<EdgeCollider2D>().points;
        edges[5] = new Vector2(x, y);
    }
}
