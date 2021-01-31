using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOffEvent : MonoBehaviour
{
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        GameEvents.current.StartCinematic += TurnOffLight;
    }

    public void TurnOffLight()
    {
        light.enabled = false;
        StartCoroutine(TurnOnLightsIEnumerator());
    }

    public IEnumerator TurnOnLightsIEnumerator()
    {
        yield return new WaitForSeconds(1f);
        light.enabled = true;
        yield return new WaitForSeconds(0.05f);
        light.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light.enabled = true;
        yield return new WaitForSeconds(0.05f);
        light.enabled = false;
        yield return new WaitForSeconds(0.4f);
        light.enabled = true;
    }
}
