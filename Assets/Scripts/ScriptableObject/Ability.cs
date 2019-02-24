using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public Sprite sprite;
    public float baseCooldown;

    public abstract void Initialize();
    public abstract void Trigger();
}
