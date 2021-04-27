using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    public GameObject prefabRock;
    public GameObject rockInstance;
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

    void Spawn()
    {
        rockInstance = Instantiate(prefabRock);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(rockInstance);
            Destroy(prefabRock);
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
            counter = 0;
        }
    }
}
