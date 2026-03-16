using UnityEngine;
using UnityEngine.InputSystem;

public class XYButtonMovement : MonoBehaviour
{
    [SerializeField] InputActionReference up;
    [SerializeField] InputActionReference down; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    void OnEnable()
    {
        up.action.Enable();
        down.action.Enable();
    }

    void OnDisable()
    {
        up.action.Disable();
        down.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (up.action.IsPressed())
        {
            MoveUp();
        }

        if (down.action.IsPressed())
        {
            MoveDown();
        }
    }

    private void MoveUp()
    {
        Debug.Log("Moving up");
    }

    private void MoveDown()
    {
        Debug.Log("Moving down");
    }
}
