using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public GameObject Obj;
    void Start()
    {
        
    }

    public void AnimationStart() 
    {
        Animator animator = Obj.GetComponent<Animator>();
        if (!animator.enabled)
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }
}
