using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform player;
//    public Vector3 offset;
    public float mouseSensitivity = 100f;
    float yaw = 0f;
    float pitch = 0f;
    // Update is called once per frame
    void Start()
	{
 //       Cursor.lockState = CursorLockMode.Locked;
	}
	void FixedUpdate()
    {
        yaw = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        pitch = Mathf.Clamp(pitch, -75f, 75f);

        transform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
        player.Rotate(Vector3.up * yaw);
    }
}
