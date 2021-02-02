using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PoisonDisplay : MonoBehaviour
{
    [SerializeField] private PoisonValue poisonValue;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI info;
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private Image disablePanel;
    [SerializeField] private bool isUsed;


    private void Start()
    {
        image.color = poisonValue.Color;
        info.text = string.Format("POISON -{0}%", poisonValue.DamagePercentage);
    }

    private void Update()
    {
        counter.text = string.Format("{0}/{1}", poisonValue.CurrentValue, poisonValue.MaxValue);

        if(!isUsed)
        {
            if (poisonValue.CurrentValue > 0)
                disablePanel.gameObject.SetActive(false);
            else
                disablePanel.gameObject.SetActive(true);
        }
        else
        {
            disablePanel.gameObject.SetActive(true);
        }
    }

    public void TurnOff(PoisonValue currentUsedPoison)
    {
        if (poisonValue.TypePoison == currentUsedPoison.TypePoison)
        {
            isUsed = true;
            
        }
    }

    public void TurnOn()
    {
        isUsed = false;
    }

}
