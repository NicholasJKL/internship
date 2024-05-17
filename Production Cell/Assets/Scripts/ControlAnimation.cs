using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    public GameObject Obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleArmAnimation()
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
