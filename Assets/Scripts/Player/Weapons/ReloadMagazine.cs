using DG.Tweening;
using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadMagazine : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private GameEvent onWeaponFinishRealoading;

    public void ReloadMagazineAniamtion(Weapon weapon)
    {
        image.DOFillAmount(1f, weapon.OverloadTime).SetEase(Ease.Unset).OnComplete(() =>
        {
            image.fillAmount = 0f;
            onWeaponFinishRealoading?.Raise();
        });
    }
}
