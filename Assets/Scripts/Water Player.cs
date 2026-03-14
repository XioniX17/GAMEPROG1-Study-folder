using UnityEngine;

//Inherits from New Player script

public class WaterPlayer : NewPlayer
{
    public NewBullet bulletPrefab;
    protected override void Attack()
    {
        NewBullet nBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        nBullet.SetDirection(lastDirection);
    }
}
