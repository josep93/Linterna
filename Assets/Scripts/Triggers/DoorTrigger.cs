using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animador;
    public BoxCollider boxCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTrigger" && InGameValues.haveKey)
        {
            //Destroy(this.gameObject);
            boxCollider.enabled = false;
            animador.Play("AbrirPuerta");
            InGameValues.haveKey = false;
        }
    }

}
