using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventSystem : MonoBehaviour
{
    public static GameEventSystem CurrentInstance;

    private void Awake()
    {
        CurrentInstance = this;
    }


    // Creating C# Event
    public event Action OnDoorwayTriggerEnter;


    public void DoorwayTriggerEnterMethod()
    {
        if (OnDoorwayTriggerEnter != null)
        {
            OnDoorwayTriggerEnter();
        }
    }
}