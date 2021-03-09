using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : ICommand
{
    private Animator m_Animator;
    
    public BasicMover(Animator animator){
        this.m_Animator=animator;
    }
    public void Excecute()
    {
        m_Animator.SetBool("Basic", true);
    }

    public void Exit()
    {
        m_Animator.SetBool("Basic", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
