using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EventsSubscriber : MonoBehaviour
{
    [SerializeField] private EventsPublisher _eventsPublisher;
    private void Start()
    {
        _eventsPublisher.OnSpacePressed += EventsPublisher_OnSpacePressed;
        _eventsPublisher.OnFloatEvent += EventsPublisher_OnFloatEvent;
        //_eventsPublisher.OnActionEvent += (bool arg1, int arg2) => Debug.Log(arg1 + " " + arg2);
        _eventsPublisher.OnActionEvent += EventsPublisher_OnActionEvent;
        _eventsPublisher.OnFuncEvent += EventsPublisher_OnFuncEvent; ;
    }
    public void TestingUnityEvent()
    {
        Debug.Log("Unity Event!");
    }
    private void EventsPublisher_OnSpacePressed(object sender, EventsPublisher.OnSpacePressedEventArgs e)
    {
        Debug.Log("Player pressed Space! Count: " + e.SpaceCount);
        //_eventsPublisher.OnSpacePressed -= EventsPublisher_OnSpacePressed;
    }
    private void EventsPublisher_OnFloatEvent(float f)
    {
        Debug.Log("Float: " + f);
    }
    private void EventsPublisher_OnActionEvent(bool arg1, int arg2)
    {
        Debug.Log(arg1 + " " + arg2);
    }
    private int EventsPublisher_OnFuncEvent(bool arg)
    {
        return 5;
    }

    private void OnDestroy()
    {
        _eventsPublisher.OnSpacePressed -= EventsPublisher_OnSpacePressed;
        _eventsPublisher.OnFloatEvent -= EventsPublisher_OnFloatEvent;
        //_eventsPublisher.OnActionEvent -= (bool arg1, int arg2) => Debug.Log(arg1 + " " + arg2);
        _eventsPublisher.OnActionEvent -= EventsPublisher_OnActionEvent;
    }
}
