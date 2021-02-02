using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Kool2Play/Create/ShotGunWeapon")]
public class ShotGunWeapon : Weapon
{
    public override void Shot()
    {
        base.Shot();

        foreach (Transform currentPoint in CurrentWeaponModel.transform.GetChild(0))
        {
            Bullet bullet = Instantiate(BulletPrefab, currentPoint).GetComponent<Bullet>();
            bullet.transform.localPosition = new Vector3(0, 0, 0);
            bullet.transform.rotation = new Quaternion(0, 0, 0, 0);
            bullet.transform.SetParent(null);
            bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            bullet.Init(SpeedBullet, DamageBullet, ColorWeapon);
        }
    }
}
