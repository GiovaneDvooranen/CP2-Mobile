using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet =
                Instantiate(
                    bulletPrefab,
                    firePoint.position,
                    firePoint.rotation);

            bullet.GetComponent<Rigidbody>()
                .linearVelocity =
                firePoint.forward * 20f;
        }
    }
}