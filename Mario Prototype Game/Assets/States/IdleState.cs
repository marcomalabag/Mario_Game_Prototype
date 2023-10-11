using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class IdleState : BaseState
{
    private float HorizontalInput;
    protected MovementStateMachine sm;

    public IdleState(MovementStateMachine MovementSM) : base("Idle", MovementSM)
    {
        sm = (MovementStateMachine)this.Machine;
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
        if (Mathf.Abs(HorizontalInput) > Mathf.Epsilon)
        {
            machineState.ChangeState(sm.walk);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            machineState.ChangeState(sm.jump);
        }

    }



    public override void Exit()
    {
        base.Exit();
    }
}
