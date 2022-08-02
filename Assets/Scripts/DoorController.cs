using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.CurrentInstance.onDoorwayTriggerEnter += OnDoorWayOpen;
        GameEventSystem.CurrentInstance.onDoorwayTriggerExit += OnDoorWayClose;
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