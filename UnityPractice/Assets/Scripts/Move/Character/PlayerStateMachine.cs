using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : Statemachine
{
    void Start()
    {
        SwitchState(new IdleState(this));
    }
}
