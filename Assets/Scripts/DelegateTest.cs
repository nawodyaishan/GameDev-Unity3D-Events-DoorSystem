using System;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    delegate void MyDelegate(string msg);

    private MyDelegate _myDelegate;


    private void Start()
    {
        _myDelegate += PrintAsName;
        _myDelegate += PrintAsHisName;
        _myDelegate("Nipuna");
    }

    void PrintAsName(string d)
    {
        Debug.Log($"My Name is00 {d}");
    }

    void PrintAsHisName(string g)
    {
        Debug.Log($"His name is {g}");
    }
}