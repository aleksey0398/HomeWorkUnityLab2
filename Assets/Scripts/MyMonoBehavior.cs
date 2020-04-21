using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MyMonoBehavior : MonoBehaviour
{
    protected Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

}

