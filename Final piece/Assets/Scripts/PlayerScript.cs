using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    [Header ("Variables")]
    [SerializeField] float          jumpSpeed;
    [SerializeField] float          setJump;
    [SerializeField] float          runSpeed;
    [SerializeField] float          setSpeed;
    
    

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
    
        if(Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    
    }



    void Jumping()
        {        

            anim.SetBool("IsRunning", true);


            if (grounded == true)
            {
                anim.SetBool("IsJumping",false);
                if (Input.GetKey("w"))
                {
                    rb.velocity =  new Vector2(0,jumpSpeed);                    
                    
                    anim.SetBool("IsJumping", true);
         
                }
                
            }

            if (grounded == false)
            {
                jumpSpeed = 0;
                rb.velocity = new Vector2(runSpeed,jumpSpeed);
                anim.SetBool("IsRunning", false);
            }


            
        }
    void Running()
    {
        float positive = setSpeed;
        float negative = -setSpeed;

        if (Input.GetKey("d"))
        {
            runSpeed = setSpeed;
            sr.flipX = false;
        }
        if (Input.GetKey("a"))
        {
            sr.flipX = true;
            runSpeed = -setSpeed;
        }
        rb.velocity = new Vector2(runSpeed,0);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause()
    {
        SceneManager.LoadScene("Main Menu");
    }

        

    void OnCollisionEnter2D( Collision2D col )
        {
            if (col.gameObject.tag == "platform")
            {
                grounded = true;
                anim.SetBool("IsJumping", false);
                jumpSpeed = setJump;
            }
        
            if(col.gameObject.tag == "rock")
            {
                Destroy(player);      
                SceneManager.LoadScene("Death Screen");

            }

            if (col.gameObject.tag == "void")
            {
                Destroy(player);
                SceneManager.LoadScene("Death Screen");
            }
            
            if (col.gameObject.tag == "levelEnd")
            {
                NextScene();
            }
            
        }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            grounded = false;
        }
    }
}
