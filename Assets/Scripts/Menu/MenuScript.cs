using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public void jugar()
    {
        SceneManager.LoadScene("New Scene");
    }

    public void salir()
    {
        Application.Quit();
    }

}
