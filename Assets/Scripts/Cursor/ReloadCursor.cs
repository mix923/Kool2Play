using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ReloadCursor : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private GameEvent onFinishShooting;

    public void ReloadCursorAniamtion(Weapon weapon)
    {
        image.DOFillAmount(1f, weapon.ShotTime).SetEase(Ease.Unset).OnComplete(() =>
        {
            image.fillAmount = 0f;
            onFinishShooting?.Raise();
        });
    }
}
