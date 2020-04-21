using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Animations : MyMonoBehavior
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.Play("RoundScale", -1, 0f);
        }
    }
}
