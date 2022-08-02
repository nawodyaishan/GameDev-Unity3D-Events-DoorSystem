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
    public event Action OnDoorwayTriggerExit;


    public void DoorwayTriggerEnterMethod()
    {
        if (OnDoorwayTriggerEnter != null)
        {
            Debug.Log("Opening Door");
            OnDoorwayTriggerEnter();
        }
    }


    public void DoorwayTriggerExitMethod()
    {
        if (OnDoorwayTriggerExit != null)
        {
            Debug.Log("Closing Door");
            OnDoorwayTriggerExit();
        }
    }
}