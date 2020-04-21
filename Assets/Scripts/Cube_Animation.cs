using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Animation : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetInteger("Cube_animate", 0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("Cube_animate", 1);

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetInteger("Cube_animate", 2);

        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetInteger("Cube_animate", 3);

        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetInteger("Cube_animate", 4);

        }
    }
}
