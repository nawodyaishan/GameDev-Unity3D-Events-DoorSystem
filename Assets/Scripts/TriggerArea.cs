using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider Entered");
        GameEventSystem.CurrentInstance.DoorwayTriggerEnterMethod();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider Exited");
        GameEventSystem.CurrentInstance.DoorwayTriggerExitMethod();
    }
}