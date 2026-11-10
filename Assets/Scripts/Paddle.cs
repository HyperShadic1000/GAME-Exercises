using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private float direction = 0f;

    void Update()
    {
        transform.position +=
            new Vector3(0f, 0f, direction * speed * Time.deltaTime);
    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            direction = -1f;
        }
        else if (context.canceled)
        {
            direction = 0f;
        }
    }

    public void OnRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            direction = 1f;
        }
        else if (context.canceled)
        {
            direction = 0f;
        }
    }
}
