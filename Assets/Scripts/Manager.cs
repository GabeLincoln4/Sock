using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject foot;
    
    void Start()
    {
        foot.AddComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        
    }
}
