using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        statemachine.inputReader.onMoving += OnMoving;
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void Exit()
    {
        Debug.Log("Idle State Exit");
        statemachine.inputReader.onMoving -= OnMoving;
    }

    public void OnMoving()
    {
        Debug.Log("Moving");
    }
}
