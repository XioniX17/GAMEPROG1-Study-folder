using UnityEngine;
using UnityEngine.InputSystem;

public class BirdPlayer : MonoBehaviour
{
    public AudioManager audioManager;
    public PigGameManager gameManager;

    public Rigidbody2D rBody;
    public PlayerInput playerInput;
    private InputAction action1;
    private float flapPower = 6.0f;

    private AudioSource audioSource;
    public AudioClip flapSFX;
    private void Start()
    {
        action1 = playerInput.actions.FindAction("Action1");
        audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        if (action1.WasPressedThisFrame())
        {
            rBody.linearVelocityY = flapPower;
            audioSource.clip = flapSFX;
            audioSource.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            gameManager.EnableGameOver("Game Over");
            audioManager.Play("Birb Die");
            Destroy(gameObject);
        }
    }
}
