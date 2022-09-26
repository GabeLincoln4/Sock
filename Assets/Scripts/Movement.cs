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
		
		
             

		if (Input.GetKeyDown(KeyCode.Space))
        {
			Debug.Log("Space Pressed");
            rb.AddForce(new Vector2(-_thrust, 0)); 
        }
	}

	void FixedUpdate()
	{
<<<<<<< HEAD
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");

		rb.velocity = new Vector2 (speed*horizontal, speed*vertical);
=======
		Vector3 movement = new Vector3(0, Input.GetAxis("Vertical") * _verticalSpeed * Time.deltaTime, 0);
		transform.position += movement * _verticalSpeed * Time.deltaTime;
>>>>>>> rocket-sock
	}	
}
