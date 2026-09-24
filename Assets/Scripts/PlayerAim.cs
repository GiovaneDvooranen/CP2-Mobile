using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    void Update()
    {
        Ray ray =
            Camera.main.ScreenPointToRay(
                Input.mousePosition);

        Plane plane =
            new Plane(Vector3.up, Vector3.zero);

        float distance;

        if (plane.Raycast(ray, out distance))
        {
            Vector3 point =
                ray.GetPoint(distance);

            Vector3 look =
                point - transform.position;

            look.y = 0;

            transform.forward =
                look;
        }
    }
}