using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [SerializeField] private WeaponGameEvent onWeaponChanged;
    [SerializeField] private WeaponGameEvent onWeaponStartRealoading;
    [SerializeField] private WeaponGameEvent onWeaponStartShooting;

    [SerializeField] private List<Weapon> playerWeapons;
    [SerializeField] private Transform weaponPlaceHolder;

    private Weapon currentWeapon;
    private bool isReloading;
    private bool isShooting;
    public int currentIndex;

    private void Start()
    {
        isReloading = false;
        isShooting = false;
        currentWeapon = playerWeapons[0];
        currentIndex = 0;

        onWeaponChanged?.Raise(currentWeapon);

        foreach (Weapon weapon in playerWeapons)
        {
            weapon.CreateWeapon(weaponPlaceHolder);
        }

        currentWeapon.CurrentWeaponModel.SetActive(true);
    }

    public void Update()
    {
        if (!isReloading && !isShooting)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                currentIndex++;
                if (currentIndex >= playerWeapons.Count)
                    currentIndex = 0;

                ChangeWeapon();
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                currentIndex--;

                if (currentIndex < 0)
                    currentIndex = playerWeapons.Count - 1;

                ChangeWeapon();
            }

            if (Input.GetMouseButtonDown(0))
            {
                currentWeapon.Shot();
                onWeaponStartShooting?.Raise(currentWeapon);
                isShooting = true;
                if (currentWeapon.CurrentAmmo == 0)
                {
                    onWeaponStartRealoading?.Raise(currentWeapon);
                    isReloading = true;
                }
            }
        }
    }

    private void ChangeWeapon()
    {
        currentWeapon.CurrentWeaponModel.SetActive(false);
        currentWeapon = playerWeapons[currentIndex];
        onWeaponChanged?.Raise(currentWeapon);
        currentWeapon.CurrentWeaponModel.SetActive(true);
    }

    public void FinishShooting()
    {
        isShooting = false;
    }

    public void AddAmmoToCurrentWeapon()
    {
        currentWeapon.CurrentAmmo = currentWeapon.OneMagazine;
        isReloading = false;
    }
}
