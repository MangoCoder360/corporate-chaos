using System.Collections;
using UnityEngine;

public class RedSquare : MonoBehaviour
{
    public GameObject targetObject;
    public Vector2 targetCoordinates;
    private bool isTriggered = false;
    private float smoothSpeed = 0.005f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        collision.gameObject.transform.localScale = Vector3.zero;
        StartCoroutine(DestroyGameObjectAfterDelay(collision.gameObject, 3f));
        isTriggered = true;
    }

    private void LateUpdate()
    {
        if (isTriggered)
        {
            Vector3 desiredPosition = new Vector3(targetCoordinates.x, targetCoordinates.y, 0);
            Vector3 smoothedPosition = Vector3.Lerp(targetObject.transform.position, desiredPosition, smoothSpeed);
            targetObject.transform.position = smoothedPosition;
        }
    }

    private IEnumerator DestroyGameObjectAfterDelay(GameObject gameobj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameobj);
    }
}
