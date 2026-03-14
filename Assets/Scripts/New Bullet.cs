using UnityEngine;

public class NewBullet : MonoBehaviour
{
    public float speed = 15.0f;
    private Vector2 direction = Vector2.right;
    private Vector2 velocity;

    private void Start()
    {
        Destroy(gameObject, 4.0f);
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }
}
