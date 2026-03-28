using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Animator animator;

    public PlayerInput playerInput;

    private InputAction moveAction;
    public float speed = 2.0f;
    private Vector2 direction = Vector2.down;
    private Vector2 lastDirection = Vector2.right;
    private Vector2 velocity;
    
    void Start()
    {
        moveAction = playerInput.actions.FindAction("Move");
    }

    
    void Update()
    {
        Movement();
    }

    private void Movement() 
    {
        direction = moveAction.ReadValue<Vector2>();
        direction.Normalize();

        animator.SetFloat("Horizontal", lastDirection.x);
        animator.SetFloat("Vertical", lastDirection.y);

        if (moveAction.IsPressed() == true)
        {
            lastDirection = direction;
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);
    }
}
