using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PoisonSphere : MonoBehaviour
{
    [SerializeField] private PoisonValue poison; 


    public void Link(PoisonValue poisonValue)
    {
        transform.localScale = new Vector3(0, 0, 0);
        poison = poisonValue;
        transform.GetComponent<MeshRenderer>().material.color = poison.TransparentColor;
        transform.DOScale(poison.Range, poison.Duration).SetEase(Ease.Unset).OnComplete(() =>
        {
            poison.onFinishedAnimating?.Raise();
            Destroy(this.gameObject);
        });
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag =="Enemy")
        {
            other.GetComponent<Enemy>().InjureByPoison(poison.DamagePercentage);
        }
    }
}
