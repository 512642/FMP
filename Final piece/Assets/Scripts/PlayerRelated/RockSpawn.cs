using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    public Vector3 offset;
    public GameObject spawner;
    public GameObject rockPrefab;
    private GameObject rockInstance;
    public Transform player;

    void Start()
    {

    }



        void Spawn()
    {
        rockInstance = Instantiate(rockPrefab);
        rockInstance.transform.position = spawner.transform.position;
        

    }
}
