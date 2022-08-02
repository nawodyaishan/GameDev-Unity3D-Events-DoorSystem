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
    public event Action onDoorwayTriggerEnter;
    public event Action onDoorwayTriggerExit;


    public void DoorwayTriggerEnterMethod()
    {
        if (onDoorwayTriggerEnter != null)
        {
            Debug.Log("Opening Door");
            onDoorwayTriggerEnter();
        }
    }


    public void DoorwayTriggerExitMethod()
    {
        if (onDoorwayTriggerExit != null)
        {
            Debug.Log("Closing Door");
            onDoorwayTriggerExit();
        }
    }
}