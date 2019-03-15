using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EmitAbility", menuName = "Ability/EmitAbility")]
public class EmitAbility : Ability
{
    public float offset;
    public float speed;
    public float lifespan;
    public Projectile prefab;
}
