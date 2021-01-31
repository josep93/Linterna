using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.StartCinematic += TurnOnLights;
    }

    public void TurnOnLights()
    {
        this.gameObject.SetActive(true);
    }
}
