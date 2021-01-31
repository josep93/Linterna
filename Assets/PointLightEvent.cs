using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightEvent : MonoBehaviour
{
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        GameEvents.current.StartCinematic += TurnOnLights;
    }

    public void TurnOnLights()
    {
        meshRenderer.enabled = true;
    }
}
