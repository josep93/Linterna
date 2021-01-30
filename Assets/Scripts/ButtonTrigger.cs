using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger")
        {
            GameEvents.current.DestroyDoorMethod();
            InGameValues.buttonDoorOpened = true;
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
