using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private float smoothSpeed = 0.02f;
    private Vector3 offset = new Vector3(0, 3, -10);

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}