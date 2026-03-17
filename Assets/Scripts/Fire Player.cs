using UnityEngine;

//Inherits from New Player script

public class FirePlayer : NewPlayer
{
    public NewBullet bulletPrefab;
    protected override void Attack()
    {
        NewBullet nBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        nBullet.SetDirection(transform.position);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}
