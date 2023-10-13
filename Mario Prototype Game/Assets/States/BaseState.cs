using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
    private string name { get; set; }
    protected StateMachine machineState { get; set; }

    public BaseState(string name, StateMachine machine)
    {
        this.name = name;
        this.machineState = machine;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public StateMachine Machine
    {
        get { return machineState; }
        set { machineState = value; }
    }


    public virtual void Enter() { } // Logic for when the state is entered in. What variables have to initialized
    public virtual void UpdateLogic() { } // Logic for when to transition to another state
    public virtual void UpdatePhysics() { } // Logic for what to do in this state or what to check
    public virtual void Exit() { } // What logic has to be done or what variables have to be deinitialized
}
