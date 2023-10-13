using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
State machine was implemented since Mario has different states.
Mario has a state where he is big and can break blocks. He also
has a state where he can shoot fireball. Although these states
weren't implemented in this project due to time constraints, 
with the FSM this feature can still be easily added. 
 */

public class StateMachine : MonoBehaviour
{
    // Start is called before the first frame update
    private BaseState CurrentState;
    void Start()
    {
        CurrentState = GetInitialState();
        if (CurrentState != null)
        {
            CurrentState.Enter();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.UpdateLogic();
        }
    }

    void LateUpdate()
    {
        if (CurrentState != null)
        {
            CurrentState.UpdatePhysics();
        }
    }

    protected virtual BaseState GetInitialState()
    /* Starting starting of the FSM, since this function is a virtual
     function, any FSM class that inherits from it will be able to override
    this function and place their own starting class*/
    {
        return null;
    }

    public void ChangeState(BaseState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
