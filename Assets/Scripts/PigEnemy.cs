using UnityEngine;

public class PigEnemy : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector2 direction = Vector2.left;

    private void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void ReverseDirection()
    {
        direction = -direction;
    }
}
