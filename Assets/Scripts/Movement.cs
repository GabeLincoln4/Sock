using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _thrust;
	[SerializeField] private float _verticalSpeed;

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
		float vertical = Input.GetAxis("Vertical");


		rb.AddForce(new Vector2(0, vertical));

		if (Input.GetKeyDown(KeyCode.Space))
        {
			Debug.Log("Space Pressed");
            rb.AddForce(new Vector2(-_thrust, 0)); 
        }
	}	
}
