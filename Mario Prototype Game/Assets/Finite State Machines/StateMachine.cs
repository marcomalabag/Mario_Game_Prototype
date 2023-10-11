using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    {
        return null;
    }

    public void ChangeState(BaseState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10f, 10f, 200f, 100f));
        string content = CurrentState != null ? CurrentState.Name : "(no current state)";
        GUILayout.Label($"<color='black'><size=40>{content}</size></color>");
        GUILayout.EndArea();
    }
}
