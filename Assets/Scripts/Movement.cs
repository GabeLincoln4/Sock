using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

	Rigidbody2D rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() 
	{

	}

	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");

		rb.velocity = new Vector2 (speed*horizontal, speed*vertical);
	}	
}
