using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDependencyDebug : MonoBehaviour
{
    public float value = 15f;
    public RandomEnum randomEnum = RandomEnum.ESSA_DWA;

    public string SetName(string value)
    {
        return value;
    }
}

public enum RandomEnum
{
    ESSA,
    ESSA_DWA,
    ESSA_TRZY
}