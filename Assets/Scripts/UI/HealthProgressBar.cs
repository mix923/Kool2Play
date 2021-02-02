using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthProgressBar : MonoBehaviour
{
    [SerializeField] private HealthValue healthValue;
    [SerializeField] private Image image;
    [SerializeField] private float speedBar;

    void Update()
    {
        image.fillAmount = Mathf.Lerp(image.fillAmount, ((healthValue.CurrentValue - 0) * 1 / healthValue.MaxValue) + 0, speedBar * Time.deltaTime);
    }
}
