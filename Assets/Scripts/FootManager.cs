using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    
    [SerializeField] private GameObject foot;
    
    void Awake()
    {
        foot.AddComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        
    }
}
