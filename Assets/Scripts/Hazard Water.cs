using UnityEngine;

public class HazardWater : HazardScript
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Bullet_G")
        {
            Destroy(gameObject);
        }
    }
}
