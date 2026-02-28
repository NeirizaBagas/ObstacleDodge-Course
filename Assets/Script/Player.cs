using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private PlayerInputs inputActions;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions = new PlayerInputs();
        inputActions.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();
        }
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }


}
