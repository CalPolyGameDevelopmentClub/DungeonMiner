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

    private void Send()
    {
        vc.movementDirection = movementDirection;
        vc.facingDirection = facingDirection;
    }
}
