using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject miLuz;

    public void jugar()
    {
        SceneManager.LoadScene("New Scene");
    }

    public void salir()
    {
        Application.Quit();
    }

    public void changeButtong(int button)
    {

        switch (button)
        {
            case 0:
                //-6 5.75 -13
                miLuz.transform.localPosition = new Vector3(miLuz.transform.localPosition.x, 5.75f, miLuz.transform.localPosition.z);
                break;

            case 1:
                //-6 2.75 -13
                miLuz.transform.localPosition = new Vector3(miLuz.transform.localPosition.x, 2.75f, miLuz.transform.localPosition.z);
                break;

            default:
                Debug.Log("Botón seleccionado: " + button);
                break;
        }
    }

}
