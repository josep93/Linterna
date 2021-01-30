using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animador;
    public BoxCollider collider;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Se ha activado");
        if (other.gameObject.tag == "PlayerTrigger" && InGameValues.haveKey)
        {
            //Destroy(this.gameObject);
            collider.enabled = false;
            animador.Play("AbrirPuerta");
            InGameValues.haveKey = false;
        }
    }

}
