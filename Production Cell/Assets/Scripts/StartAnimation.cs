using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public bool ReadyToGo = false;
    public GameObject Obj;
    void Start()
    {
        
    }
    private void Update()
    {
        if (ReadyToGo) 
        {
            AnimationStart();
            ReadyToGo = false;
        }
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
