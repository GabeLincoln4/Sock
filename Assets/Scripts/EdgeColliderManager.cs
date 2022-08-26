using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    public EdgeCollider2D ModifyCollider(GameObject gameObject)
    {
        EdgeCollider2D edgeBorder;

        edgeBorder = gameObject.AddComponent<EdgeCollider2D>();
        return edgeBorder;
    }
}
