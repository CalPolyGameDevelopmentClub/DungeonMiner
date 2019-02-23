using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float baseSpeed;

    private Rigidbody2D rb;
    private VirtualController vc; 
    private Loadout lo;
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vc = GetComponent<VirtualController>();
        lo = GetComponent<Loadout>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) rb.velocity = baseSpeed * lo.speed * vc.movementDirection;
    }
}
