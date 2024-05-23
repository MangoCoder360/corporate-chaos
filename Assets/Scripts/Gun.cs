using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform player;
    public GameObject projectilePrefab;
    private float projectileSpeed = 30f;
    private float cooldown = 0.1f;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        Vector3 direction = mousePosition - player.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
        transform.position = player.position + direction.normalized * 1.1f;

        if (Input.GetMouseButton(0))
        {
            if (cooldown < 0)
            {
                Shoot(direction);
                cooldown = 0.1f;
            }
        }

        cooldown -= Time.deltaTime;
    }

    private void Shoot(Vector3 direction)
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = direction.normalized * projectileSpeed;
        }
    }
}
