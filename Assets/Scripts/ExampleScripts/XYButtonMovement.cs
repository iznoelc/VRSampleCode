using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This class demonstrates how to use Input Actions to control behavior when certain buttons are pressed (X & Y) on the Meta quest controllers
/// </summary>
public class XYButtonMovement : MonoBehaviour
{
    // references to the up & down input actions in the InputSystem_Actions 
    [SerializeField] InputActionReference up;
    [SerializeField] InputActionReference down; 

    // make sure the actions are enabled on enable
    void OnEnable()
    {
        up.action.Enable();
        down.action.Enable();
    }

    // and disabled on disable
    void OnDisable()
    {
        up.action.Disable();
        down.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        // if the up button is pressed, call MoveUp()
        if (up.action.IsPressed())
        {
            MoveUp();
        }

        // uf the down button is pressed, call MoveDown()
        if (down.action.IsPressed())
        {
            MoveDown();
        }
    }

    /// <summary>
    /// This method is what should happen when the up button is pressed
    /// </summary>
    private void MoveUp()
    {
        Debug.Log("Moving up");
    }

    /// <summary>
    /// This method is what should happen if the down button is pressed
    /// </summary>
    private void MoveDown()
    {
        Debug.Log("Moving down");
    }
}
