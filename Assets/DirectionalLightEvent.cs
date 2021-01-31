using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightEvent : MonoBehaviour
{
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
        GameEvents.current.StartCinematic += TurnOnLights;
        light.enabled = false;
    }

    public void TurnOnLights()
    {
        StartCoroutine(TurnOnLightsIEnumerator());
    }

    public IEnumerator TurnOnLightsIEnumerator()
    {
        yield return new WaitForSeconds(1.6f);
        light.enabled = true;
    }
}
