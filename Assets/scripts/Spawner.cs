using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1.5f;
    public float maxHeight = 12f;
    public float minHeight = 4f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

  
    private void Spawn()
    {

        Vector3 spawnLocation = new Vector3(-8, Random.Range(minHeight, maxHeight), -3);//pipes spawn location
        Instantiate(prefab, spawnLocation, Quaternion.identity);
        

    }
}
