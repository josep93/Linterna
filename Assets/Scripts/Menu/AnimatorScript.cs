using System.Collections;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator animacion;
    private Coroutine corrutina;
    private int aux = 2;
    private int temporizador = 2;

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
        temporizador = 15;
        switch (aux)
        {
            case 1:
                animacion.Play("LightTitle" + aux);
                corrutina = StartCoroutine("lanzarAnimacion");

                aux = 2;
                break;

            case 2:
                animacion.Play("LightTitle" + aux);
                corrutina = StartCoroutine("lanzarAnimacion");

                aux = 1;
                break;
        }

        
    }
}
