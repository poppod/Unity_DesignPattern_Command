using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafeMover : ICommand
{
    private Animator m_Animator;
    public StrafeMover(Animator animator){
        this.m_Animator=animator;
    }
    public void Excecute()
    {
        m_Animator.SetBool("Strafe", true);
    }

    public void Exit()
    {
        m_Animator.SetBool("Strafe", false);
    }

    
    
}
