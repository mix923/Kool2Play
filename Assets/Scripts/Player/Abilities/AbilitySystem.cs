using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbilitySystem : MonoBehaviour
{
    [SerializeField] private GameEvent OnPlayerDeath;

    [SerializeField] private SprintValue sprintValue; 
    [SerializeField] private HealthValue healthValue; 

    public void Start()
    {
        sprintValue.CurrentValue = sprintValue.MaxValue;
        healthValue.CurrentValue = healthValue.MaxValue;
    }

    private void Update()
    {
        
    }

    public void AddBonusSprint()
    {
        if (sprintValue.CurrentValue < sprintValue.MaxValue)
        {
            sprintValue.CurrentValue += sprintValue.Bonus;
            if (sprintValue.CurrentValue > sprintValue.MaxValue)
                sprintValue.CurrentValue = sprintValue.MaxValue;
        }
    }

    public void AddBonusHealth()
    {
        if (healthValue.CurrentValue < healthValue.MaxValue)
        {
            healthValue.CurrentValue += healthValue.Bonus;
            if (healthValue.CurrentValue > healthValue.MaxValue)
                healthValue.CurrentValue = healthValue.MaxValue;
        }
    }

    public void SubtractHealth(float damageValue)
    {
        healthValue.CurrentValue -= damageValue;
        if(healthValue.CurrentValue <=0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
