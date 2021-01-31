using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerBridge : MonoBehaviour
{

    private Animator animator;
    [SerializeField]
    private Collider bridgeCollider;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.tag == "PlayerTrigger")
        {
            animator.SetTrigger("ButtonPress");
            bridgeCollider.enabled = false;
        }
    }
}
