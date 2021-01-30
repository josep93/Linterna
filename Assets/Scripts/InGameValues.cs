using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameValues : MonoBehaviour
{
    public static bool paused;
    public static bool haveKey;
    public static bool buttonDoorOpened;

    private void Awake()
    {
        paused = false;
        haveKey = false;
        buttonDoorOpened = false;
    }
}
