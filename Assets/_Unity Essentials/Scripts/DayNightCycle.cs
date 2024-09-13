using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration of a full day in seconds
    [Tooltip("The duration of a full day in seconds")]
    public float dayDuration = 120f; // Default: 120 seconds for a full cycle

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed in degrees per second
        float rotationSpeed = 360f / dayDuration;
        
        // Rotate the directional light around the X-axis to simulate day passing
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
