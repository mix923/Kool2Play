using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Kool2Play/Create/SprintValue")]
public class SprintValue: ScriptableObject
{
    [Range(0, 200)] public float CurrentValue;
    [Range(0, 200)] public float MaxValue;
    [Range(0, 10)] public float Bonus;
}
