using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderManager : MonoBehaviour
{
    public Vector2[] ModifyCollider(GameObject gameObject)
    {
        Vector2[] edgeBorder;

        edgeBorder = gameObject.AddComponent<EdgeCollider2D>().points;
        edgeBorder[0] = new Vector2(-.32f, 0f);
        edgeBorder[1] = new Vector2(.18f, 0f);
        return edgeBorder;
    }
}
