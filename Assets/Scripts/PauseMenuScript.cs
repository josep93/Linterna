using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static PauseMenuScript current;
    
    void Start()
    {
        current = this;
        gameObject.SetActive(false);
        OtherEvents();
    }

    private void OtherEvents()
    {
        GameEvents.current.PausePressed += OnPause;
    }

    private void OnPause(bool paused)
    {
        gameObject.SetActive(paused);
    }

    public void Resume()
    {
        if (InGameValues.paused)
        {
            GameEvents.current.PressPause();
        }
    }

    public void Leave()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
