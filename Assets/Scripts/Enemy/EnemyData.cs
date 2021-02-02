using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Team { Red, Green, Blue, Yellow}

[CreateAssetMenu(menuName = "Kool2Play/Create/EnemyData")]
public class EnemyData : ScriptableObject
{
    public Team Team;
    public float ShootTime;
    public Color Color;
    public float SpawnDelay;
    public float SpeedMovement;
    public float MaxHp;
    public float Damage;
}
