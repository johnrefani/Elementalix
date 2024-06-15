using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform core;  // The core around which the object will circle
    public float radius = 5f;  // Radius of the circle
    public float speed = 2f;   // Rotation speed

    private void Update()
    {
        // Calculate the position of the object around the core in a circular motion
        float angle = Time.time * speed;
        Vector3 newPosition = core.position + new Vector3(Mathf.Cos(angle) * radius, 0f, Mathf.Sin(angle) * radius);

        // Update the object's position
        transform.position = newPosition;
    }
}
