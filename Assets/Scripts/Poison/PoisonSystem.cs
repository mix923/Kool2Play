using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSystem : MonoBehaviour
{
    [SerializeField] private PoisonValueGameEvent onUsedPoison;

    [SerializeField] private Transform player;
    [SerializeField] private GameObject prefabPoison;
    [SerializeField] private PoisonValue poisonValueSoft;
    [SerializeField] private PoisonValue poisonValueNormal;
    [SerializeField] private PoisonValue poisonValueHeavy;

    private bool canUsePoisonSoft;
    private bool canUsePoisonNormal;
    private bool canUsePoisonHeavy;

    private void Start()
    {
        poisonValueSoft.CurrentValue = poisonValueSoft.MaxValue;
        poisonValueNormal.CurrentValue = poisonValueNormal.MaxValue;
        poisonValueHeavy.CurrentValue = poisonValueHeavy.MaxValue;

        canUsePoisonSoft = true;
        canUsePoisonNormal = true;
        canUsePoisonHeavy = true;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && canUsePoisonSoft && poisonValueSoft.CurrentValue >= 1)
        {
            CreateShperePoison(poisonValueSoft);
            canUsePoisonSoft = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && canUsePoisonNormal && poisonValueNormal.CurrentValue >= 1)
        {
            CreateShperePoison(poisonValueNormal);
            canUsePoisonNormal = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && canUsePoisonHeavy && poisonValueHeavy.CurrentValue >= 1)
        {
            CreateShperePoison(poisonValueHeavy);
            canUsePoisonHeavy = false;
        }
    }

    private void CreateShperePoison(PoisonValue poisonValue)
    {
        onUsedPoison?.Raise(poisonValue);
        poisonValue.CurrentValue -= 1;
        PoisonSphere poisonSphere = Instantiate(prefabPoison, player.transform.position, Quaternion.identity).GetComponent<PoisonSphere>();
        poisonSphere.Link(poisonValue);
    }


    public void AddPoisonSoft()
    {
        if(poisonValueSoft.CurrentValue < poisonValueSoft.MaxValue)
            poisonValueSoft.CurrentValue += 1;
    }

    public void AddPoisonNormal()
    {
        if (poisonValueNormal.CurrentValue < poisonValueNormal.MaxValue)
            poisonValueNormal.CurrentValue += 1;
    }

    public void AddPoisonHeavyt()
    {
        if (poisonValueHeavy.CurrentValue < poisonValueHeavy.MaxValue)
            poisonValueHeavy.CurrentValue += 1;
    }

    public void UnLockPoisonSoft()
    {
        canUsePoisonSoft = true;
    }
    public void UnLockPoisonNormal()
    {
        canUsePoisonNormal = true;
    }

    public void UnLockPoisonHeavy()
    {
        canUsePoisonHeavy = true;
    }

}
