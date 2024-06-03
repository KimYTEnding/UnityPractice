using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : Statemachine
{
    /*private enum CharacterState
    {
        Idle,
        Run,
        Jump,
        Dead
    }*/

    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new IdleState(this));
    }
}
