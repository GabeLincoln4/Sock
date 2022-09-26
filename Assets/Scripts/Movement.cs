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
		
	}	

	public void MoveVertically(float speed)
	{
		Vector3 movement = new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime, 0);
		transform.position += movement * speed * Time.deltaTime;
	}
}
