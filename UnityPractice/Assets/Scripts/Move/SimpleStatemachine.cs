using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SimpleStatemachine : MonoBehaviour
{
    public State currentState;
    
    public void SwitchState(State newState)
    {
        if (currentState == newState)
        {
            Debug.Log("same State");
            return;
        }
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
    // Update is called once per frame
    void Update()
    {
        currentState.Tick(Time.deltaTime);
    }
}
