using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : BaseState
{
    
    protected MovementStateMachine sm;

    private bool onGround;
    private float HorizontalInput;
    private int GroundLayer = 1 << 8;

    public JumpingState(MovementStateMachine MovementSM): base("Jumping", MovementSM)
    {
        this.sm = (MovementStateMachine)this.Machine;
    }
    public override void Enter()
    {
        base.Enter();
        // When entering this state, the gameObject with the MovementStateMachine will already be in midair
        Vector2 vel = sm.rb.velocity;
        vel.y += sm.JumpForce;
        HorizontalInput = 0.0f;
        sm.rb.velocity = vel;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        HorizontalInput = Input.GetAxis("Horizontal"); // Get directional input from the user
        if (onGround)
            this.Machine.ChangeState(sm.idle);
    }
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 vector = sm.rb.velocity;
        vector.x = HorizontalInput * sm.speed; // Used so that directional input can be taken in
        sm.rb.velocity = vector;
        onGround = sm.rb.velocity.y < Mathf.Epsilon && sm.rb.IsTouchingLayers(GroundLayer); //Checks if the user is already on the ground layer
    }

    
   


}
