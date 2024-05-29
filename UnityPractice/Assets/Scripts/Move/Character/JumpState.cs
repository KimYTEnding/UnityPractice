using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    public override void Enter()
    {
        Debug.Log("Jump State Enter");
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void Exit()
    {
        Debug.Log("Jump State Exit");
    }
}
