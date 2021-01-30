using System.Collections;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator animacion;
    private Coroutine corrutina;
    private int aux = 1;
    private int temporizador = 4;

    private void Start()
    {
        corrutina = StartCoroutine("lanzarAnimacion");
        
    }

    private void OnDestroy()
    {
        StopCoroutine(corrutina);
    }

    IEnumerator lanzarAnimacion()
    {
        yield return new WaitForSeconds(temporizador);

        switch (aux)
        {
            case 1:
                temporizador = 15;
                animacion.Play("LightTitle" + aux);
                corrutina = StartCoroutine("lanzarAnimacion");

                aux = 2;
                break;

            case 2:
                temporizador = 15;
                animacion.Play("LightTitle" + aux);
                corrutina = StartCoroutine("lanzarAnimacion");

                aux = 1;
                break;
        }

        
    }
}
