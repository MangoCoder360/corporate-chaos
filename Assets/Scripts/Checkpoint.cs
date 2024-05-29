using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private bool isTriggered = false;
    private float smoothSpeed = 0.03f;
    private Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }

    private void LateUpdate()
    {
        Vector3 offset = Vector3.zero;
        if (isTriggered)
        {
            offset.y = 10;
        }
        else
        {
            offset = Vector3.zero;
        }

        Vector3 desiredPosition = originalPosition + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}