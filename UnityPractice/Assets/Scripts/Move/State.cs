using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    /*protected SimpleStatemachine _stateMachine;

    public State(SimpleStatemachine statemachine)
    {
        _stateMachine = statemachine;
    }*/
    public abstract void Enter();
    public abstract void Tick(float deltaTime);
    public abstract void Exit();
    /*public event Action asdf; 
    public void aeee()
    {
        asdf?.Invoke();
    }*/
}
