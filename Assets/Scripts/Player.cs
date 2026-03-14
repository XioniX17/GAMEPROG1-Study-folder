using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Animator animator;

    public PlayerInput playerInput;

    private InputAction moveAction;
    public float speed = 2.0f;
    private Vector2 direction = Vector2.down;
    private Vector2 velocity;
    
    void Start()
    {
        moveAction = playerInput.actions.FindAction("Move");
    }

    
    void Update()
    {
        direction = moveAction.ReadValue<Vector2>();
        direction.Normalize();

        animator.SetBool("IsWalking", moveAction.IsPressed());


        velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);
    }
}
