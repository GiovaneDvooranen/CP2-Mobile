using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 3f;
    private float nextDamageTime;
    public float damage = 10f;
    public float attackCooldown = 0.5f;
    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        if (Time.time < nextDamageTime)
            return;

        nextDamageTime = Time.time + attackCooldown;

        collision.gameObject
        .GetComponent<PlayerHealth>()
        .TakeDamage(damage);
    }
}