using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterClass", menuName = "CharacterClass", order = 1)]
public class CharacterClass : ScriptableObject
{
    public int health;
    public int power;
    public int speed;
}
