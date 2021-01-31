using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    private Light luz;
    [SerializeField]
    private GameObject esfera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger")
        {
            esfera.SetActive(false);
            luz.enabled = false;
            GameEvents.current.DestroyDoorMethod();
            InGameValues.buttonDoorOpened = true;
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
