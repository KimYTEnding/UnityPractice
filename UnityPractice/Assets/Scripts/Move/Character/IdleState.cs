using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    protected PlayerStateMachine statemachine;
    
    public IdleState(PlayerStateMachine statemachine)
    {
        this.statemachine = statemachine;
    }

    public override void Enter()
    {
        Debug.Log("Idle State Enter");
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void Exit()
    {
        Debug.Log("Idle State Exit");
    }

    public void OnMoving()
    {

    }
}
