using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : SimpleStatemachine
{
    private enum CharacterState
    {
        Idle,
        Run,
        Jump,
        Dead
    }

    // Start is called before the first frame update
    void Start()
    {
        State Idle = new IdleState();
        State Run = new RunState();
        State Jump = new JumpState();
        State Dead = new DeadState();

        currentState = Idle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
