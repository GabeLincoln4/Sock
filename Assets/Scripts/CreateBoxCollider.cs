using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoxCollider : MonoBehaviour
{
    public GameObject go;
    public Vector2 size;

    private void AddBoxCollider2D(ref GameObject go, Vector2 size, Vector2 center)
    {
        BoxCollider2D boxCollider2D = go.AddComponent<BoxCollider2D>();
        boxCollider2D.size = size;
        boxCollider2D.offset = center;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
