using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator m_animator;
    public CharacterController m_characterController;
    // Start is called before the first frame update
    Vector3 motion= new Vector3();
    float playerSpeed=8;
    bool groundedPlayer;
    ICommand moveMentCommand;
    BasicMover basicMover;
    StrafeMover strafeMover;
    SwordMover swordMover;
    void Start()
    {
        basicMover=new BasicMover(m_animator);
        strafeMover= new StrafeMover(m_animator);
        swordMover=new SwordMover(m_animator);
        moveMentCommand= basicMover;
        moveMentCommand.Excecute();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(key: KeyCode.Q))
        {
            ChangeToStrafeMover();
        }
        if (Input.GetKeyDown(key: KeyCode.E))
        {
            ChangeToBasicMover();
        }
        if (Input.GetKeyDown(key: KeyCode.R))
        {
            ChangeToSwordMover();
        }
    }
    private void FixedUpdate() {
        Mover();
    }

    private void Mover()
    {
        groundedPlayer = m_characterController.isGrounded;
        motion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (motion != Vector3.zero)
        {
            m_characterController.gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(motion), Time.deltaTime * 10);
            //transform.rotation = Quaternion.LookRotation(motion);
        }
        m_characterController.Move(motion * playerSpeed * Time.deltaTime);
        
        SetMoveAnimation(motion);
        
        
    }

    void SetMoveAnimation(Vector3 move){
        m_animator.SetFloat("moveX",  move.x);
		m_animator.SetFloat("moveZ",  move.z);
    }
    public void ChangeToBasicMover(){
        if(moveMentCommand!=null){
            moveMentCommand.Exit();
            moveMentCommand=basicMover;
            moveMentCommand.Excecute();
        }
        
    }
    public void ChangeToStrafeMover(){
        if(moveMentCommand!=null){
            moveMentCommand.Exit();
            moveMentCommand=strafeMover;
            moveMentCommand.Excecute();
        }
        
    }
    public void ChangeToSwordMover(){
        if(moveMentCommand!=null){
            moveMentCommand.Exit();
            moveMentCommand=swordMover;
            moveMentCommand.Excecute();
        }
        
    }
}
