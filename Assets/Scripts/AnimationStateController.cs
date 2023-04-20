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
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool("IsWalking");
        bool wPressed = Input.GetKey(KeyCode.W);

        if (!IsWalking && wPressed)
        {
            animator.SetBool("IsWalking",true);
            Debug.Log("IsWalking is true");
        }

        if (!wPressed)
        {
            animator.SetBool("IsWalking", false);
            Debug.Log("IsWalking is false");
        }
    }
}
