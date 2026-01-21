using UnityEngine;

public class SpherePlatform : MonoBehaviour
{
    [HideInInspector] public bool sphereOnPlatform;

    public void Start()
    {
        sphereOnPlatform = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Debug.Log("Sphere has been placed on the platform!");
            sphereOnPlatform = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            Debug.Log("Sphere has been removed from the platform!");
            sphereOnPlatform = false;
        }
    }
}
