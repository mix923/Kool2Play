using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Kool2Play/Create/ReferenceWeapon")]
public class Weapon : ScriptableObject
{
    public string Name;
    public Color ColorWeapon; // For better understanding weapon on GUI, in final version here schould be the image of weapon
    public GameObject InitWeaponModel;
    public GameObject CurrentWeaponModel;
    public GameObject BulletPrefab;
    public float SpeedBullet;
    public float DamageBullet;
    public float OverloadTime;
    public float ShotTime;
    public int CurrentAmmo;
    public int OneMagazine;

    public void CreateWeapon(Transform parent)
    {
        CurrentWeaponModel = Instantiate(InitWeaponModel, parent);
        CurrentWeaponModel.GetComponent<MeshRenderer>().material.color = ColorWeapon;
        CurrentAmmo = OneMagazine;
    }

    public virtual void Shot()
    {
        CurrentAmmo -= 1;
    }
}
