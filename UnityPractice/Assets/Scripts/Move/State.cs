using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected SimpleStatemachine stateMachine;

    public State(SimpleStatemachine sm)
    {
        stateMachine = sm;
    }
    public abstract void Enter();
    public abstract void Tick(float deltaTime);
    public abstract void Exit();

    protected void Destroy(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
