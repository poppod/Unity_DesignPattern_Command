using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMover : ICommand
{
    private Animator m_Animator;
    public SwordMover(Animator animator){
        this.m_Animator=animator;
    }
    public void Excecute()
    {
        m_Animator.SetBool("Sword", true);
    }

    public void Exit()
    {
        m_Animator.SetBool("Sword", false);
    }

    
}
