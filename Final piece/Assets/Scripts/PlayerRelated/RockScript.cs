using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    private int counter;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Timer();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(rock);
        }
        if(col.gameObject.tag == "void")
        {
            Destroy(rock);
        }
    }
    void Timer()
    {       
        int counter = 3;

        if (counter > 0)
        {
           Subtract();
        }
        else 
        {
            print("spawn");
        }
    }
    void Subtract()
    {
        counter = counter - 1;
    }
}
