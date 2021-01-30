using UnityEngine;

public class DoorButtonScript : MonoBehaviour
{

    void Start()
    {
        GameEvents.current.DestroyDoor += DestroySelf;
    }

    public void DestroySelf()
    {
        Destroy(this.gameObject);
        GameEvents.current.DestroyDoor -= DestroySelf;
    }
}
