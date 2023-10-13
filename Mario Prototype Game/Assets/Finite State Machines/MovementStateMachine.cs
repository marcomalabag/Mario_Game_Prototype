using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
FSM was implemented since Mario has different states.
His movement is either walking, idle or jumping. But in 
case more movement features are to be implemented then 
adding a new movement feature can be done in an organized way.
*/


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

    public float JumpDrag;

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
