using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEventSystem.CurrentInstance.DoorwayTriggerEnterMethod();
    }

    private void OnTriggerExit(Collider other)
    {
        GameEventSystem.CurrentInstance.DoorwayTriggerExitMethod();
    }
}