using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : State
{
    public override void Enter()
    {
        Debug.Log("Run State Enter");
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
        Debug.Log("Run State Exit");
    }
}
