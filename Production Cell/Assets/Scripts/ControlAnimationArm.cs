using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimationArm : MonoBehaviour
{
    public GameObject Arm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleArmAnimation()
    {

        Animator animator = Arm.GetComponent<Animator>();
        if (animator.enabled == false)
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }
}
