using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mitch died on this anthill
public class Evasion : MonoBehaviour
{
    [SerializeField] private VirtualController vc;
    [SerializeField] private Movement m;
    [SerializeField] private Loadout lo;

    public EvadeAbility evadeAbility;

    private float evadeTimeLeft = 0.0f;
    private float iTimeLeft = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Cooldowns();
        Invincibility();
    }

    private void CheckInput()
    {
        if (vc.evade > 0.0f && evadeTimeLeft == 0.0f) {
            Trigger(evadeAbility);
            evadeTimeLeft = evadeAbility.baseCooldown;
        }
    }

    private void Trigger(EvadeAbility ability)
    {
        //Do stuff here
    }

    private void Cooldowns()
    {
        if (evadeTimeLeft > 0.0f) {
            evadeTimeLeft = Mathf.Clamp(
                evadeTimeLeft - Time.deltaTime, 
                0.0f, 
                evadeAbility.baseCooldown
            );
        }
    }

    private void Invincibility()
    {

    }
}
