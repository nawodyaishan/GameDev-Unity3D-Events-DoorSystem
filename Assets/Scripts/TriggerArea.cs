using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collider Entered");
            GameEventSystem.CurrentInstance.DoorwayTriggerEnterMethod(id);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collider Exited");
            GameEventSystem.CurrentInstance.DoorwayTriggerExitMethod(id);
        }
    }
}