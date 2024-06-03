using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : State
{
    protected PlayerStateMachine playerStateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        playerStateMachine = stateMachine;
    }
    public override void Enter()
    {

    }
    public override void Tick(float deltaTime)
    {

    }
    public override void Exit()
    {

    }
}
