using Oculus.Interaction;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Determines the behavior of the door and whether the player should be able to move to the next level. 
/// </summary>
public class DoorBehavior : MonoBehaviour
{
    [SerializeField] private SpherePlatform sPlatform; // the platform the sphere should be placed on
    [SerializeField] private CubePlatform cPlatform;  // the platform the cube should be placed on 
    private bool canExitLevel; // whether the player can exit the level

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canExitLevel = false;
    }

    /// <summary>
    /// If the player has placed the cube and sphere on the platform and they haven't already been able to exit the level, allow the player to exit the level.
    /// </summary>
    void Update()
    {
        if (cPlatform.cubeOnPlatform && sPlatform.sphereOnPlatform && !canExitLevel)
        {
            Debug.Log("Player is able to exit the level");
            canExitLevel = true;
        }
    }

    /// <summary>
    /// If the player collides with the door and they are able to exit level, move them to the next scene.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canExitLevel)
        {
            Debug.Log("Player is exiting the level!");
            SceneManager.LoadScene("Scene2");
        }
    }
}
