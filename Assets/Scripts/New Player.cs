using UnityEngine;
using UnityEngine.InputSystem;

//This will act as a template for what players will be.
//Inhereitance study

public class NewPlayer : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction actionA;
    private InputAction moveAction;

    public float speed = 10.0f;
    private Vector2 direction;
    protected Vector2 lastDirection = Vector2.right;
    private Vector2 velocity;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        actionA = playerInput.actions.FindAction("Action A");
        moveAction = playerInput.actions.FindAction("Move");
    }

    void Update()
    {
        if (actionA.WasPressedThisFrame())
        {
            Attack();
        }

        Movement();
    }

    private void Movement()
    {
        direction = moveAction.ReadValue<Vector2>();
        direction.Normalize();

        if(actionA.IsPressed())
        {
            lastDirection = direction;
        }

        velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);
    }

    /*
       Parent - Virtual
       Child - Override
    */
    protected virtual void Attack()
    {

    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pokeball")
        {
            Destroy(gameObject);
        }
    }
}
