using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : State
{
    public override void Enter()
    {
        Debug.Log("Dead State Enter");
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void Exit()
    {
        Debug.Log("Dead State Exit");
    }
}
