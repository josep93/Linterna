using UnityEngine;

public class DoorButtonScript : MonoBehaviour
{
    public BoxCollider collider;
    public Animator animador;

    void Start()
    {
        GameEvents.current.DestroyDoor += DestroySelf;
    }

    public void DestroySelf()
    {
        //Destroy(this.gameObject);
        GameEvents.current.DestroyDoor -= DestroySelf;
        collider.enabled = false;
        animador.Play("AbrirPuerta");
    }
}
