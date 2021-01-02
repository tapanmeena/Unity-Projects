using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMover : Photon.MonoBehaviour
{
	// new multiplayer varibales
	public PhotonView photonView;
	public Text PlayerNameText;

	// Update is called once per frame
	private CharacterController controller;
	private Vector3 playerVelocity = new Vector3(0, 0, 0);
	private bool groundedPlayer;
	private float playerSpeed = 3.0f;
	[SerializeField]
	float sprintSpeed = 6.0f;
	[SerializeField]
	float normalSpeed = 3.0f;
	private float jumpHeight = 1.0f;
	private float gravityValue = -9.81f;
	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private void Start()
	{
		controller = gameObject.AddComponent<CharacterController>();
		controller.radius = 1f;
	}

	void FixedUpdate()
	{
		if(photonView.isMine)
		{
			// reset the current scene
			if (Input.GetKeyDown("r"))
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			groundedPlayer = controller.isGrounded;
			if (groundedPlayer && playerVelocity.y < 0)
			{
				playerVelocity.y = 0f;
			}
			//sprint
			if (Input.GetKey(KeyCode.LeftShift))
				playerSpeed = sprintSpeed;
			else
				playerSpeed = normalSpeed;

			//player movement
			Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
			controller.Move(move * Time.deltaTime * playerSpeed);

			// Changes the height position of the player..
			if (Input.GetButtonDown("Jump") && groundedPlayer)
			{
				playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
			}
			playerVelocity.y += gravityValue * Time.deltaTime;
			controller.Move(playerVelocity * Time.deltaTime);
		}
	}
}
