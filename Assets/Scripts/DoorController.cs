using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.CurrentInstance.OnDoorwayTriggerEnter += OnDoorWayOpen;
        GameEventSystem.CurrentInstance.OnDoorwayTriggerExit += OnDoorWayClose;
    }

    // Opening The Door
    void OnDoorWayOpen()
    {
        LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEaseOutQuad();
    }

    // Closing The Door
    void OnDoorWayClose()
    {
        LeanTween.moveLocalY(gameObject, 0.75f, 1f).setEaseInQuad();
    }
}