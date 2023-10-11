using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStateMachine : StateMachine
{
    // Start is called before the first frame update
    [HideInInspector]
    public IdleState idle;

    [HideInInspector]
    public WalkingState walk;

    public Rigidbody2D rb;

    public float speed;

    public float JumpForce;

    private void Awake()
    {
        idle = new IdleState(this);
        walk = new WalkingState(this);
    }

    protected override BaseState GetInitialState()
    {
        return idle;
    }
}
