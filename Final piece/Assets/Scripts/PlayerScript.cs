using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //public Animator anim;
    public GameObject player;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Running();
    }


    void Running()
    {
        //anim.SetBool("IsRunning", false);
        float xv = 0;
        if (Input.GetKey("d"))
        {
            xv = 10;
            //anim.SetBool("IsRunning",true);
        }
        if (Input.GetKey("a"))
        {
            xv = -10;
            //anim.SetBool("IsRunning",true);
        }
        rb.velocity = new Vector2(xv,0);
    }

 void OnCollisionEnter2D( Collision2D col )
    {

     
        if(col.gameObject.tag == "rock")
        {      
            print("hit!");
        }
    
    }
}
