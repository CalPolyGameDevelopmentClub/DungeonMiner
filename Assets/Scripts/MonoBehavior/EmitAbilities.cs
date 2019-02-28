using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitAbilities : MonoBehaviour
{
    [SerializeField] private VirtualController vc;
    [SerializeField] private Loadout lo;

    public EmitAbility primaryAbility;
    public EmitAbility secondaryAbility;

    private float primaryTimeLeft = 0.0f;
    private float secondaryTimeLeft = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Cooldowns();
    }

    private void CheckInput() 
    {
        if (vc.primary > 0.0f && primaryTimeLeft == 0.0f) {
            Trigger(primaryAbility);
            primaryTimeLeft = primaryAbility.baseCooldown;
        }
        if (vc.secondary > 0.0f && secondaryTimeLeft == 0.0f) {
            Trigger(secondaryAbility);
            secondaryTimeLeft = secondaryAbility.baseCooldown;
        }
    }

    private void Trigger(EmitAbility ability)
    {
        Vector2 offset = vc.facingDirection * ability.offset;
        Instantiate(
            ability.prefab,
            transform.position + new Vector3(offset.x, offset.y, 0.0f),
            Quaternion.identity
        );
    }

    private void Cooldowns() 
    {
        if (primaryTimeLeft > 0.0f) {
            primaryTimeLeft = Mathf.Clamp(
                primaryTimeLeft - Time.deltaTime, 
                0.0f, 
                primaryAbility.baseCooldown
            );
        }

        if (secondaryTimeLeft > 0.0f) {
            secondaryTimeLeft = Mathf.Clamp(
                secondaryTimeLeft - Time.deltaTime, 
                0.0f, 
                secondaryAbility.baseCooldown
            );
        }
    }
}
