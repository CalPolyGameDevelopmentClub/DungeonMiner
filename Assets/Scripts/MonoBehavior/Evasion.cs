using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mitch died on this anthill
public class Evasion : MonoBehaviour
{
    [SerializeField] private VirtualController vc;
    [SerializeField] private Movement m;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Loadout lo;

    public EvadeAbility ea;

    private float abilityTimeLeft = 0.0f;
    private float evadeTimeLeft = 0.0f;
    private float iTimeLeft = 0.0f;

    [SerializeField] private bool invincible = false;

    // Start is called before the first frame update
    void Start()
    {
        ea = lo.evade;   
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Cooldowns();
    }

    private void CheckInput()
    {
        if (vc.evade > 0.0f && abilityTimeLeft == 0.0f) {
            Trigger(ea);
        }
    }

    private void Trigger(EvadeAbility a)
    {
        //Do stuff here
        abilityTimeLeft = a.baseCooldown;
        evadeTimeLeft = a.evadeTime;
        m.canMove = false;
        rb.velocity = vc.movementDirection * (a.rollDistance / a.evadeTime);
        iTimeLeft = a.iTime;
        InvincibilityOn();
    }

    private void Cooldowns()
    {
        //activation
        if (abilityTimeLeft > 0.0f) {
            abilityTimeLeft = Mathf.Clamp(
                abilityTimeLeft - Time.deltaTime, 
                0.0f, 
                ea.baseCooldown
            );
        }

        //actually evading
        if (evadeTimeLeft > 0.0f) {
            evadeTimeLeft = Mathf.Clamp(
                evadeTimeLeft - Time.deltaTime,
                0.0f,
                ea.evadeTime
            );
        }
        else {
            m.canMove = true;
        }

        //invincibility
        if (iTimeLeft >0.0f) {
            iTimeLeft = Mathf.Clamp(
                iTimeLeft - Time.deltaTime,
                0.0f,
                ea.iTime
            );
        }
        else {
            InvincibilityOff();
        }
    }

    private void InvincibilityOn()
    {
        invincible = true;
    }

    private void InvincibilityOff()
    {
        invincible = false;
    }
}
