using UnityEngine;

public class HazardGrass : HazardScript
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Bullet_F")
        {
            Destroy(gameObject);
        }
    }
}
