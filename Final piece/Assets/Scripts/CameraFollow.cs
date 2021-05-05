using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public PlayerScript PlayerScript;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //CheckTransform();
    }

    /*void CheckTransform()
    {
        if (PlayerScript.alive == false)
        {
            print("player died");
        }
    }*/
}
