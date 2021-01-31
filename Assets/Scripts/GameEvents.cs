using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InGameValues;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
        PausePressed = Prueba;
        DestroyDoor = VoidMethod;
        StartCinematic = StartingCinematic;
    }

    public event Action<bool> PausePressed;
    public event Action StartCinematic;
    public event Action DestroyDoor;
    public void PressPause()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        PausePressed(paused);
    }

    public void Prueba(bool prueba)
    {
        Debug.Log(prueba==true?"pausa":"continue");
    }

    public void VoidMethod()
    {
        Debug.Log("");
    }

    public void StartingCinematic()
    {
        Debug.Log("Starting Cinematic");
    }

    public void DestroyDoorMethod()
    {
        DestroyDoor();
    }

    public void StartCinematicMethod()
    {
        StartCinematic();
    }

}
