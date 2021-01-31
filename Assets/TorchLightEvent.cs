using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLightEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.StartCinematic += TurnOffLights;
    }

    public void TurnOffLights()
    {
        this.gameObject.SetActive(false);
    }
}
