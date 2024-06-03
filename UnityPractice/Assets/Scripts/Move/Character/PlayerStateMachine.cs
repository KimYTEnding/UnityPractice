using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : Statemachine
{
    public InputReader inputReader;
    void Start()
    {
        SwitchState(new IdleState(this));
    }
}
