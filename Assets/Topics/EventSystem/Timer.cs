using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private Action _timerCallback;
    private float _timer;
    void Update()
    {
        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0f)
            {
                _timerCallback();
            }
        }
    }

    public void SetTimer(float timer, Action timerCallback)
    {
        _timer = timer;
        _timerCallback = timerCallback;
    }
}
