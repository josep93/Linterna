using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameValues : MonoBehaviour
{
    public static bool paused;

    private void Awake()
    {
        paused = false;
    }
}
