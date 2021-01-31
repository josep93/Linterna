using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofEvent : MonoBehaviour
{
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        GameEvents.current.StartCinematic += TurnOnRoof;
    }

    public void TurnOnRoof()
    {
        meshRenderer.enabled = true;
    }
}
