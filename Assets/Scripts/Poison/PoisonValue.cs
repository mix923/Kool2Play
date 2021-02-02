using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypePoison { Soft, Middle, Hard}

[CreateAssetMenu(menuName = "Kool2Play/Create/PoisonValue")]
public class PoisonValue : ScriptableObject
{
    public float Range;
    public float Duration;
    public Color Color;
    public Color TransparentColor;
    public TypePoison TypePoison;
    public int DamagePercentage;
    public int CurrentValue;
    public int MaxValue;

    public GameEvent onFinishedAnimating;
}
