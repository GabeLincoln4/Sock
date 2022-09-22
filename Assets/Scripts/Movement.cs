using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _thrust;

	private Rigidbody2D rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() 
	{

	}

	void FixedUpdate()
	{
		
		if (Input.GetKeyDown(KeyCode.Space))
        {
			Debug.Log("Space Pressed");
            rb.AddRelativeForce(new Vector2(-_thrust, 0)); 
        }
	}	
}
