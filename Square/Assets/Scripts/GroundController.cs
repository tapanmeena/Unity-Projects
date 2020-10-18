using UnityEngine;

public class GroundController : MonoBehaviour
{
    public Transform player;

    void FixedUpdate()
    {
        if (2 * Mathf.Abs(player.position.z) + 300 >= transform.localScale.z)
        {
            Vector3 v = transform.localScale;
            Debug.Log("increase ground to infinity");
            Debug.Log("Before");
            Debug.Log(transform.localScale.z);
            v.z *= 2;
            transform.localScale = v;
            Debug.Log("After");
            Debug.Log(transform.localScale.z);
        }
    }
}