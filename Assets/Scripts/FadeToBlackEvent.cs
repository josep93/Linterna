using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlackEvent : MonoBehaviour
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
        StartCoroutine(FadeToBlack());
    }

    public IEnumerator FadeToBlack()
    {
        yield return new WaitForSeconds(3);
        meshRenderer.enabled = true;
        MusicScript.stopMusic();
    }
}
