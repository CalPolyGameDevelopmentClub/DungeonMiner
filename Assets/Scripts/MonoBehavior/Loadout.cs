using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadout : MonoBehaviour
{
    public CharacterClass baseClass;
    public int maxHP;
    public int power;
    public int speed;
    public EmitAbility primary;
    public EmitAbility secondary;
    public EvadeAbility evade;

    // Start is called before the first frame update
    void Awake()
    {
        maxHP = baseClass.health;
        power = baseClass.power;
        speed = baseClass.speed;
        primary = baseClass.primary;
        secondary = baseClass.secondary;
        evade = baseClass.evade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
