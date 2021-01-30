using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject luzSelector;
    public GameObject luzRaton;
    public Camera camara;
    private PlayerInputs playerInputs;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Enable();
    }

    private void Update()
    {
        var vector = playerInputs.Player.MousePosition.ReadValue<Vector2>();
        var vectorMundo = camara.ScreenToWorldPoint(new Vector3(vector.x, vector.y, 15.36f));
        luzRaton.transform.position = new Vector3(vectorMundo.x, vectorMundo.y, -3);
    }

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
                luzSelector.transform.position = new Vector3(luzSelector.transform.position.x, -0.5f, luzSelector.transform.position.z);
                break;

            case 1:
                //-6 2.75 -13
                luzSelector.transform.position = new Vector3(luzSelector.transform.position.x, -3.2f, luzSelector.transform.position.z);
                break;

            default:
                Debug.Log("Botón seleccionado: " + button);
                break;
        }
    }

}
