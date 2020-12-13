using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
	public float forceApplied = -10;
	public float rotation = -50;
	private void FixedUpdate()
	{
		if (Input.GetKey("w"))
			transform.position += new Vector3(forceApplied, 0, forceApplied);
		if (Input.GetKey("s"))
			transform.position += new Vector3(-forceApplied, 0, -forceApplied);

		if (Input.GetKey("a"))
		{
			float angle = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, rotation, transform.rotation.z));
		}
	}
}
