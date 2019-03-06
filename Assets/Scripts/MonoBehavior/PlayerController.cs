using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string movementVerticalAxis;
    public string movementHorizontalAxis;
    public string facingVerticalAxis;
    public string facingHorizontalAxis;
    public string primaryAxis;
    public string secondaryAxis;
    public string dodgeAxis;

    private Vector2 movementDirection;
    private Vector2 facingDirection;
    private float primary;
    private float secondary;
    private float evade;
    private VirtualController vc;

    // Start is called before the first frame update
    void Start()
    {
        vc = GetComponent<VirtualController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Facing();
        Activations();
        Send();
    }

    private void Movement()
    {
        movementDirection = new Vector2(
            Input.GetAxisRaw(movementHorizontalAxis),
            Input.GetAxisRaw(movementVerticalAxis)
        ).normalized;
    }

    private void Facing()
    {
        facingDirection = new Vector2(
            Input.GetAxisRaw(facingHorizontalAxis),
            Input.GetAxisRaw(facingVerticalAxis)
        ).normalized;
    }

    private void Activations()
    {
        primary = Input.GetAxisRaw(primaryAxis);
        secondary = Input.GetAxisRaw(secondaryAxis);
        evade = Input.GetAxisRaw(dodgeAxis);
    }

    private void Send()
    {
        vc.movementDirection = movementDirection;
        vc.facingDirection = facingDirection;
        
        //Should be pushing to input buffer
        vc.primary = primary;
        vc.secondary = secondary;
        vc.evade = evade; 
    }
}
