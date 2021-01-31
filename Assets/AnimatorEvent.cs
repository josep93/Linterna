using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEvent : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        GameEvents.current.StartCinematic += StartAnimator;
        animator = GetComponent<Animator>();
    }

    public void StartAnimator()
    {
        animator.enabled = true;
    }
}
