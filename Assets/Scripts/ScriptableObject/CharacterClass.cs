using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterClass", menuName = "CharacterClass")]
public class CharacterClass : ScriptableObject
{ 
    [Range(0, 5)] public int health;
    [Range(0, 5)] public int power;
    [Range(0, 5)] public int speed;

    public EmitAbility primary;
    public EmitAbility secondary;
    public EvadeAbility evade;
}
