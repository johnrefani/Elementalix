using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Adjust the speed of rotation as needed

    void Update()
    {
        // Rotate the object around its X-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
