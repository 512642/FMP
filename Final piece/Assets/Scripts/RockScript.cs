using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{

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
    }
    void Timer()
    {
        int counter = 0;
        
        
        while (counter < 300 )
        {
            counter ++;
            print (counter);
        }
        if (counter > 300)
        {
            Instantiate(rock);
            counter = 0;
        }
    }
}
