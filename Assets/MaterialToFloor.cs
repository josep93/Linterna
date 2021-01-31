using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialToFloor : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField]
    Material newMaterial;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.StartCinematic += ChangeMaterial;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeMaterial()
    {
        meshRenderer.material = newMaterial;
    }
}
