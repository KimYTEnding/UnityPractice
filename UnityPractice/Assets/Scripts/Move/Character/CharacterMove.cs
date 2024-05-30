using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : SimpleStatemachine
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
