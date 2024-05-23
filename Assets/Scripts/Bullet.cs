using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float collisionTime = 0;

    private void OnCollisionStay2D(Collision2D collision)
    {
        collisionTime += Time.deltaTime;

        if (collisionTime > 5)
        {
            Destroy(gameObject);
        }
    }
}
