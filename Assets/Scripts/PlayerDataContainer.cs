using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerDataContainer", menuName = "Create ScriptableObject/PlayerDataContainer", order = 0)]
public class PlayerDataContainer : ScriptableObject 
{
    public Animator m_Animator= new Animator();
    public CharacterController m_PlayerController= new CharacterController();
   
}

