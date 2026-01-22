using UnityEngine;

/// <summary>
/// Determines when the sphere enters a designated platform.
/// </summary>
public class SpherePlatform : MonoBehaviour
{
    [HideInInspector] public bool sphereOnPlatform; // variable to determine whether sphere is on the platform

    public void Start()
    {
        sphereOnPlatform = false;
    }

    /// <summary>
    /// Sets sphere on platform to true when the sphere stays on the platform
    /// </summary>
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Debug.Log("Sphere has been placed on the platform!");
            sphereOnPlatform = true;
        }
    }

    /// <summary>
    /// Sets sphere on platform to false if sphere is removed from the platform
    /// </summary>
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Debug.Log("Sphere has been removed from the platform!");
            sphereOnPlatform = false;
        }
    }
}
