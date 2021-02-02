using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Kool2Play/Create/GunWeapon")]
public class GunWeapon : Weapon
{
    public override void Shot()
    {
        base.Shot();

        Bullet bullet = Instantiate(BulletPrefab, CurrentWeaponModel.transform.GetChild(0)).GetComponent<Bullet>();
        bullet.transform.localPosition = new Vector3(0, 0, 0);
        bullet.transform.rotation = new Quaternion(0, 0, 0, 0);
        bullet.transform.SetParent(null);
        bullet.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        bullet.Init(SpeedBullet, DamageBullet, ColorWeapon);
    }
}
