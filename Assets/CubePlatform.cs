using UnityEngine;

public class CubePlatform : MonoBehaviour
{
    [HideInInspector] public bool cubeOnPlatform;

    public void Start()
    {
        cubeOnPlatform = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Cube has been placed on the platform!");
            cubeOnPlatform = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Cube has been removed from the platform!");
            cubeOnPlatform = false;
        }
    }
}
