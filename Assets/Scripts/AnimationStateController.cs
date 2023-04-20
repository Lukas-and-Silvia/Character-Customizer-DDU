using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", true);
            Debug.Log("IsWalking is true");
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", false);
            Debug.Log("IsWalking is false");
        }
    }
}
