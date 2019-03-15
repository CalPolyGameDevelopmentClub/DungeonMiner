using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityObject : MonoBehaviour
{
    [HideInInspector] public float speed;
    [HideInInspector] public float lifespan;
    [HideInInspector] public float power;
    [HideInInspector] public Vector2 direction;
    public bool isMeleee;

    private float timeAlive = 0.0f;

    void Update() 
    {
        Life();
    }

    private void Life()
    {
        timeAlive += Time.deltaTime;
        if (timeAlive >= lifespan) Death();
    }

    //call on death stuff for projectile. (might need to move to death script)
    //maybe this activates an event
    private void Death()
    {
        Destroy(gameObject);
    }
}
