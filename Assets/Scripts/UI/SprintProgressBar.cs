using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SprintProgressBar : MonoBehaviour
{

    [SerializeField] private SprintValue sprintValue;
    [SerializeField] private Image image;
    [SerializeField] private float speedBar;

    void Update()
    {
        image.fillAmount =  Mathf.Lerp(image.fillAmount, ((sprintValue.CurrentValue - 0) * 1 / sprintValue.MaxValue) + 0, speedBar * Time.deltaTime);       
    }
}
