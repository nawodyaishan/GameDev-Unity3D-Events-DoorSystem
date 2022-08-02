using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.CurrentInstance.OnDoorwayTriggerEnter += OnDoorWayOpen;
    }

    // Opening The Door
    void OnDoorWayOpen()
    {
        LeanTween.
    }
}