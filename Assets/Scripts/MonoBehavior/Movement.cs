using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private VirtualController vc; 
    [SerializeField] private Loadout lo;

    public float baseSpeed;

    private bool canMove = true;

    // Start is called before the first frame update
    /*void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vc = GetComponent<VirtualController>();
        lo = GetComponent<Loadout>();
    }*/

    // Update is called once per frame
    void Update()
    {
        if (canMove) rb.velocity = baseSpeed * lo.speed * vc.movementDirection;
    }
}
