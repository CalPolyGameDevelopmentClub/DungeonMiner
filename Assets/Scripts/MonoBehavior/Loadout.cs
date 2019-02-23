using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadout : MonoBehaviour
{
    public CharacterClass baseClass;
    public int maxHP;
    public int power;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = baseClass.health;
        power = baseClass.power;
        speed = baseClass.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
