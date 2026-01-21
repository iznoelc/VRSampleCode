using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Light direcLight;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        direcLight.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }

}
