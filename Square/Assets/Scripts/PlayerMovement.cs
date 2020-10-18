using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
//    public Transform movement;
    public Text scoreText, CurrentScoreText;
    public float ForwardForce = 4000f;
    bool moveLeft = false, moveRight = false;
    float sidewayForce = 120f;

    // Update is called once per frame
    void FixedUpdate () 
    {
        //Debug.Log(howMuch);
        rb.AddForce (0, 0, -ForwardForce * Time.deltaTime);
        if (moveRight) 
        {
            rb.AddForce (sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }
        if (moveLeft) 
        {
            rb.AddForce (-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }
        if(rb.position.y < -1f)
        {
            //enabled = false;
//            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Update () 
    {
        float x = Input.GetAxis("Horizontal");
        if (x > 0)
            moveLeft = true;
        if (x < 0)
            moveRight = true;
        scoreText.text = Mathf.Abs(rb.position.z * 0.5f).ToString("0");
        CurrentScoreText.text = scoreText.text;
    }
}