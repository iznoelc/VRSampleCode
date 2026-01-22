using UnityEngine;

/// <summary>
/// Determines when a cube enters a designated platform.
/// </summary>
public class CubePlatform : MonoBehaviour
{
    [HideInInspector] public bool cubeOnPlatform; // variable to determine whether the cube is on the platform

    public void Start()
    {
        cubeOnPlatform = false;
    }

    /// <summary>
    /// Sets cubeOnPlatform to true when cube remains on the platform
    /// </summary>
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Cube has been placed on the platform!");
            cubeOnPlatform = true;
        }
    }

    /// <summary>
    /// Sets cubeOnPlatform to false when the cube exits the platform. 
    /// </summary>
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Cube has been removed from the platform!");
            cubeOnPlatform = false;
        }
    }
}
