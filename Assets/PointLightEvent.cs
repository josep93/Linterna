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
        StartCoroutine(TurnOnLightsIEnumerator());
    }

    public IEnumerator TurnOnLightsIEnumerator()
    {
        yield return new WaitForSeconds(1f);
        meshRenderer.enabled = true;
        yield return new WaitForSeconds(0.1f);
        meshRenderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        meshRenderer.enabled = true;
        yield return new WaitForSeconds(0.1f);
        meshRenderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        meshRenderer.enabled = true;
    }
}
