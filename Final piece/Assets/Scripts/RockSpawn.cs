using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    public GameObject spawner;
    public GameObject rockPrefab;
    private GameObject rockInstance;


        void Spawn()
    {
        rockInstance = Instantiate(rockPrefab);
        

    }

}
