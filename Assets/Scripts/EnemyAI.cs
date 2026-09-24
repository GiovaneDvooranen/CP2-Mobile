using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 3f;

    Transform player;

    void Start()
    {
        player =
            GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject
            .GetComponent<PlayerHealth>()
            .TakeDamage(10 * Time.deltaTime);
        }
    }

}