using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : BaseState
{
    private float HorizontalInput;
    protected MovementStateMachine sm;

    public WalkingState(MovementStateMachine MovementSM) : base("Walking", MovementSM)
    {
        sm = (MovementStateMachine)this.machineState;
    }

    public override void Enter()
    {
        base.Enter();
        HorizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        HorizontalInput = Input.GetAxis("Horizontal");
        
        if (Mathf.Abs(HorizontalInput) < Mathf.Epsilon)
        {
            machineState.ChangeState(sm.idle);
        }
    }
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 vector = sm.rb.velocity;
        vector.x = HorizontalInput * sm.speed;
        sm.rb.velocity = vector;
    }

    public override void Exit()
    {
        base.Exit();
    }
}
