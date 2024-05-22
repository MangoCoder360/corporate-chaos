using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Force);
        }
    }
}