using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private SpriteRenderer sr;
    public Animator anim;
    public GameObject player;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
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
        float xv = 0;
        if (Input.GetKey("d"))
        {
            xv = 5;
            anim.SetBool("IsRunning",true);
        }
        if (Input.GetKey("a"))
        {
            xv = -5;
            sr.flipX = true;
            anim.SetBool("IsRunning",true);
        }
        rb.velocity = new Vector2(xv,0);
    }
    

    void Jumping()
    {
        
    }

 void OnCollisionEnter2D( Collision2D col )
    {

     
        if(col.gameObject.tag == "rock")
        {      
            print("hit!");
        }
    
    }
}
