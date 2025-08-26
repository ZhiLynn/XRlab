using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        //if player presses s key
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isSquating",true);
        }
       
        if (Input.GetKey(KeyCode.P))
        {
            animator.SetBool("isPlanking",true);
        }

        if (Input.GetKey(KeyCode.U))
        {
            animator.SetBool("isUping",true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isSquating",false);
            animator.SetBool("isPlanking",false);
            animator.SetBool("isUping",false);
        }
    }
}
