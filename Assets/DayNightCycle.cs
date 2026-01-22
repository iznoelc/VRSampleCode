using UnityEngine;

/// <summary>
/// Creates a simple day night cycle by rotating a directional light in the scene along one axis.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private Light direcLight;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        direcLight.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }

}
