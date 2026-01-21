using Oculus.Interaction;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour
{
    [SerializeField] private SpherePlatform sPlatform;
    [SerializeField] private CubePlatform cPlatform; 
    private bool canExitLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canExitLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cPlatform.cubeOnPlatform && sPlatform.sphereOnPlatform && !canExitLevel)
        {
            Debug.Log("Player is able to exit the level");
            canExitLevel = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canExitLevel)
        {
            Debug.Log("Player is exiting the level!");
            SceneManager.LoadScene("Scene2");
        }
    }
}
