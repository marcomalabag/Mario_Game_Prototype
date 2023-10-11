using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class JumpingState : BaseState
{
    // Start is called before the first frame update
    protected MovementStateMachine sm;

    private bool onGround;
    private int GroundLayer = 1 << 8;

    public JumpingState(MovementStateMachine MovementSM): base("Jumping", MovementSM)
    {
        this.sm = (MovementStateMachine)this.Machine;
    }
    public override void Enter()
    {
        base.Enter();
        Vector2 vel = sm.rb.velocity;
        vel.y += sm.JumpForce;
        sm.rb.velocity = vel;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (onGround)
            this.Machine.ChangeState(sm.idle);
    }
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();


        onGround = sm.rb.velocity.y < Mathf.Epsilon && sm.rb.IsTouchingLayers(GroundLayer);
    }

    
   


}
