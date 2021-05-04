using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [Header ("Variables")]
    [SerializeField] float          jumpSpeed = 0;
    [SerializeField] float          SetJump = 5000.0f;
    [SerializeField] float          jumpZero = 0;
    [SerializeField] float          runSpeed = 0;
    [SerializeField] float          SetSpeed = 10;
    
    

    [Header("Player Parts")]
     public GameObject player;
    public GameObject playerInstance;
    public Rigidbody2D rb;
    public Rigidbody2D playerRigidbody;

    [Header("Player Bools")]
    [SerializeField] bool           grounded = false;

    [Header("Animation")]
    public Animator anim;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    
    }
    void PlayerSpawn()
    {
        playerInstance =  Instantiate(player);
    }

    // Update is called once per frame
    void Update()
    {
        Running();
        Jumping();
    }


    void Running()
    {
        anim.SetBool("IsRunning", false);
        sr.flipX = false;
        runSpeed = 0;
        if (Input.GetKey("d"))
        {
            anim.SetBool("IsRunning",true);
            runSpeed = SetSpeed;
        }
        if (Input.GetKey("a"))
        {
            sr.flipX = true;
            anim.SetBool("IsRunning",true);
            runSpeed = -SetSpeed;
        }
        rb.velocity = new Vector2(runSpeed,0);
    }
    

    void Jumping()
    {        


        anim.SetBool("IsJumping",false);
        if (Input.GetKeyDown("w"))
        {
            rb.AddForce( new Vector2(0,jumpSpeed));
            anim.SetBool("IsJumping", true);
        }
        
    }

 void OnCollisionEnter2D( Collision2D col )
    {
        if (col.gameObject.tag == "platform")
        {
            grounded = true;
            jumpSpeed = SetJump;
        }

        else
        {
            grounded = false;
            jumpSpeed = jumpZero;
        }
     
        if(col.gameObject.tag == "rock")
        {
            Destroy(player);            
        }
        
    }
}
