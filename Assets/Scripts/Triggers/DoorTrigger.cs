using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public bool needKey;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Se ha activado");
        if (other.gameObject.tag == "PlayerTrigger" && InGameValues.haveKey)
        {
            Destroy(this.gameObject);
            InGameValues.haveKey = false;
        }
    }

}
