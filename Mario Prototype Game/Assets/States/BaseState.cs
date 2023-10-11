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


    public virtual void Enter() { }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
    public virtual void Exit() { }
}
