using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.StartCinematic += TurnOnLights;
        this.gameObject.SetActive(false);
    }

    public void TurnOnLights()
    {
        this.gameObject.SetActive(true);
    }
}
