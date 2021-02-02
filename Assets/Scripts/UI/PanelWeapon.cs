using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelWeapon : MonoBehaviour
{
    [SerializeField] private Image weaponImage;
    [SerializeField] private TextMeshProUGUI weaponName;
    [SerializeField] private TextMeshProUGUI weaponAmmo;

    private Weapon cuurentWeapon;

    public void UpdateWeapon(Weapon weapon)
    {
        cuurentWeapon = weapon;
        weaponName.text = string.Format("Weapon: {0}", cuurentWeapon.Name);
        weaponImage.color = weapon.ColorWeapon;
    }

    private void Update()
    {
        if(cuurentWeapon != null)
            weaponAmmo.text = string.Format("Ammo: {0} / {1} ", cuurentWeapon.CurrentAmmo, cuurentWeapon.OneMagazine);
    }
}
