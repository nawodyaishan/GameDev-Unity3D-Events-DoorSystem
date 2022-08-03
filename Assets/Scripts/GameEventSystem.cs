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
    public event Action<int> OnDoorwayTriggerEnter;
    public event Action<int> OnDoorwayTriggerExit;


    public void DoorwayTriggerEnterMethod(int id)
    {
        if (OnDoorwayTriggerEnter != null)
        {
            Debug.Log("Opening Door");
            OnDoorwayTriggerEnter(id);
        }
    }


    public void DoorwayTriggerExitMethod(int id)
    {
        if (OnDoorwayTriggerExit != null)
        {
            Debug.Log("Closing Door");
            OnDoorwayTriggerExit(id);
        }
    }
}