using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
    }

    void OnSceneLoaded(Scene escena, LoadSceneMode mode)
    {
        if (escena.name.Equals("Menu"))
        {
            Destroy(this.gameObject);
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
    
}
