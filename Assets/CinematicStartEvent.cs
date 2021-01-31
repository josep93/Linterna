using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicStartEvent : MonoBehaviour
{
    [SerializeField]
    private int escenarioSiguiente;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log(other);
            GameEvents.current.StartCinematicMethod();
        }
    }
}
