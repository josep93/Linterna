using UnityEngine;

public class KeyTrigger : MonoBehaviour
{

    private void OnDestroy()
    {
        Debug.Log("El juagor ha conseguido la llave: " + InGameValues.haveKey);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger")
        {
            InGameValues.haveKey = true;
            Destroy(this.gameObject);
            
        }
    }
}
