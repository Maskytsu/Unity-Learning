using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegete(int i);

    private TestDelegate _testDelegateFunction;
    private TestDelegate _testDelegateFunctionPartTwo;
    private TestBoolDelegete _testBoolDelegateFunction;

    private Action _testAction;
    private Action<int, float> _testIntFloatAction; //przyjmuje int i float
    private Func<bool> _testFunc; //zwraca bool
    private Func<int, bool> _testFuncPartTwo; //przyjmuje int, zwraca bool (ostatni typ to ten, który jest zwracany)
    private void Start()
    {
        Debug.Log("1-------------------------------------");
        _testDelegateFunction = MyTestDelegateFunction;
        _testDelegateFunction();
        _testDelegateFunction = new TestDelegate(MySecondTestDelegateFunction);
        _testDelegateFunction();
        Debug.Log("2-------------------------------------");
        _testDelegateFunctionPartTwo += MyTestDelegateFunction;
        _testDelegateFunctionPartTwo += MySecondTestDelegateFunction;
        _testDelegateFunctionPartTwo();
        _testDelegateFunctionPartTwo -= MyTestDelegateFunction;
        _testDelegateFunctionPartTwo();
        Debug.Log("3-------------------------------------");
        _testBoolDelegateFunction = MyTestBoolDelegateFunction;
        Debug.Log(_testBoolDelegateFunction(1));
        Debug.Log(_testBoolDelegateFunction(6));
        Debug.Log("4-------------------------------------");
        _testDelegateFunction = delegate () { Debug.Log("Anonymous method"); };
        _testDelegateFunction();
        Debug.Log("5-------------------------------------");
        _testDelegateFunction = () => { Debug.Log("Lamda expression"); }; //gdy u¿ywamy tego lub anonymousów, to nie mo¿emy ich usun¹æ -=
        _testDelegateFunction();
        _testBoolDelegateFunction = (int value) => { return value < 5; };
        Debug.Log(_testBoolDelegateFunction(1));
        _testBoolDelegateFunction = (int value) => value < 5; //mo¿na pomijaæ brackety, je¿eli jest tylko jedna linijka
        Debug.Log(_testBoolDelegateFunction(6));
        Debug.Log("6-------------------------------------");
        _testIntFloatAction = (int i, float f) => { Debug.Log(i + " " + f); }; //action to skrót na delegate void
        _testIntFloatAction(1, 5.25f);
        Debug.Log("7-------------------------------------");
        _testFunc = () => true; //action to skrót na delegate void
        _testFunc();
        _testFuncPartTwo = (int value) => value < 5;
        _testFuncPartTwo(3);
    }

    private void MyTestDelegateFunction()
    {
        Debug.Log("MyTestDelegateFunction");
    }

    private void MySecondTestDelegateFunction()
    {
        Debug.Log("MySecondTestDelegateFunction");
    }

    private bool MyTestBoolDelegateFunction(int value)
    {
        return value < 5;
    }
}
