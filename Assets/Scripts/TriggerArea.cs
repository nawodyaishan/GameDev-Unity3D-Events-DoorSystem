using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collider Entered");
            GameEventSystem.CurrentInstance.DoorwayTriggerEnterMethod();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collider Exited");
            GameEventSystem.CurrentInstance.DoorwayTriggerExitMethod();
        }
    }
}