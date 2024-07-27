using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimer : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    void Start()
    {
        _timer.SetTimer(1f, () => { Debug.Log("Timer complete!"); });
    }
}
