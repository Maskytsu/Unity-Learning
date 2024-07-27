using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsPublisher : MonoBehaviour
{
    //----------------------------------------------------------------------
    public class OnSpacePressedEventArgs : EventArgs
    {
        public int SpaceCount;
    }
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;
    //----------------------------------------------------------------------
    public delegate void TestEventDelegate(float f);
    public event TestEventDelegate OnFloatEvent;
    //----------------------------------------------------------------------
    public event Action<bool, int> OnActionEvent;
    //----------------------------------------------------------------------
    public UnityEvent OnUnityEvent;
    //----------------------------------------------------------------------
    public event Func<bool, int> OnFuncEvent;
    //----------------------------------------------------------------------
    private int? FuncValue = 0;
    private int _spaceCount;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spaceCount ++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { SpaceCount  = _spaceCount});

            OnFloatEvent?.Invoke(5.5f);

            OnActionEvent?.Invoke(true, 56);

            OnUnityEvent?.Invoke();

            FuncValue += OnFuncEvent?.Invoke(true);
            Debug.Log(FuncValue);
        }
    }
}
