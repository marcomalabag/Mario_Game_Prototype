using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementStateMachine : StateMachine
{
    // Start is called before the first frame update
    [HideInInspector]
    public IdleState idle;

    [HideInInspector]
    public WalkingState walk;

    [HideInInspector]
    public JumpingState jump;

    public Rigidbody2D rb;

    public float speed;

    public float JumpForce;

    private void Awake()
    {
        idle = new IdleState(this);
        walk = new WalkingState(this);
        jump = new JumpingState(this);
    }

    protected override BaseState GetInitialState()
    {
        return idle;
    }
}
