using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int current;
    public bool isDead = false;

    private Loadout lo;

    // Start is called before the first frame update
    void Start()
    {
        lo = GetComponent<Loadout>();
    }

    // Update is called once per frame
    void Update()
    {
        if (current == 0 && !isDead) {
            Death();
        }
    }

    public void Damage(int damage)
    {
        current = Mathf.Clamp(current - damage, 0, lo.maxHP);
    }

    public void Heal(int heal)
    {
        current = Mathf.Clamp(current + heal, 0, lo.maxHP);
    }

    public void Death()
    {
        Debug.Log(gameObject.name + " died");
        //do stuff here
        isDead = true;
    }
}
