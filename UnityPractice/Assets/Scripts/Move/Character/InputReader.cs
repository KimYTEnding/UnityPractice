using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputReader : Singleton<InputReader>
{
    public event Action onMoving;

    public void OnMoving()
    {
        onMoving?.Invoke();
    }
}
