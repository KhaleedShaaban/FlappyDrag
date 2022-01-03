using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovment : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private float leftEdge;
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 28f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        } 
    }

}
