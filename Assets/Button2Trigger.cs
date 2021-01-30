using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InGameValues;

public class Button2Trigger : MonoBehaviour
{
    private bool loaded;
    private Animator animator;
    [SerializeField]
    private Animator buttonAnimator;
    [SerializeField]
    private Collider collider;


    private void Start()
    {
        loaded = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="PlayerTrigger" && haveKey && !loaded)
        {
            loaded = true;
            animator.SetTrigger("Load");
        }

        else if(other.gameObject.tag == "PlayerTrigger" && loaded)
        {
            animator.SetTrigger("Siege");
        }
    }

    public void PressButton()
    {
        buttonAnimator.SetTrigger("ButtonPress");
        collider.enabled = false;
    }
}
