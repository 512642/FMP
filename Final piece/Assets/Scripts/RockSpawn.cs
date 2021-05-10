using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    public Vector3 offset;
    private float time = 0.0f;
    private float timeCounter = 2.0f;
    public GameObject spawner;
    public GameObject rockPrefab;
    private GameObject rockInstance;
    public Transform player;

    void Start()
    {

    }

    void update()
    {
        time += Time.deltaTime;

        if(time > timeCounter)
        {
            time = 0.0f;
            transform.position = player.position + offset;
        }
    }

        void Spawn()
    {
        rockInstance = Instantiate(rockPrefab);
        rockInstance.transform.position = spawner.transform.position;
        

    }
}
