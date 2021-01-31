using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicScript : MonoBehaviour
{

    public static GameObject current;

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
        current = this.gameObject;
    }

    void OnSceneLoaded(Scene escena, LoadSceneMode mode)
    {
        if (escena.name.Equals("Menu"))
        {
            Destroy(this.gameObject);
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }

    public static void stopMusic()
    {
        current.SetActive(false);
    }
    
}
