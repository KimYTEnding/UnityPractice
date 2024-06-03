using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputReader : Singleton<InputReader>
{
    public event Action onMoving;

    public void OnMoving(InputAction.CallbackContext context)
    {
        onMoving?.Invoke();
    }
}
