using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 move =
        new Vector3(h, 0, v).normalized;

        controller.Move(
        move *
        speed *
        Time.deltaTime
        );
    }
}