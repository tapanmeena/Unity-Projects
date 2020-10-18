using UnityEngine;
//using UnityEngine.Se

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.name != "Ground")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}