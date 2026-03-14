using UnityEngine;
using UnityEngine.InputSystem;

public class FlapScript : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputAction flap;
    public float flap_Power;
    public Rigidbody2D rbody;

    
    void Start()
    {
        flap = playerInput.actions.FindAction("Flap");
    }

    
    void Update()
    {
        if (flap.WasPressedThisFrame())
        {
            rbody.linearVelocityY = flap_Power;
        }
    }
}
