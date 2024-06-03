using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputReader : MonoBehaviour
{
    protected PlayerStateMachine playerStateMachine;
    public event Action onMoving;

    public void OnMoving()
    {
        onMoving?.Invoke();
    }
}
