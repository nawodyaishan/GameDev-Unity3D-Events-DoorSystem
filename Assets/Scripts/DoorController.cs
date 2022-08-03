using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.CurrentInstance.OnDoorwayTriggerEnter += OnDoorWayOpen;
        GameEventSystem.CurrentInstance.OnDoorwayTriggerExit += OnDoorWayClose;
    }

    // Opening The Door
    void OnDoorWayOpen(int id)
    {
        if (id == this.id)
        {
            LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEaseOutQuad();
        }
    }

    // Closing The Door
    void OnDoorWayClose(int id)
    {
        if (this.id == id)
        {
            LeanTween.moveLocalY(gameObject, 0.75f, 1f).setEaseInQuad();
        }
    }

    private void OnDestroy()
    {
        GameEventSystem.CurrentInstance.OnDoorwayTriggerEnter -= OnDoorWayOpen;
        GameEventSystem.CurrentInstance.OnDoorwayTriggerExit -= OnDoorWayClose;
    }
}