using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrigger : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer roca;
    private void OnDestroy()
    {
        Debug.Log("El juagor ha conseguido la llave: " + InGameValues.haveKey);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger")
        {
            roca.enabled = false;
            InGameValues.haveKey = true;
        }
    }
}
