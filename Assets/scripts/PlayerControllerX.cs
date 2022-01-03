using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpforce;
    public float gravitymodifier;
    


    // Start is called before the first frame update
    void Start()
    {

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;


        playerRb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            
        }



    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("obstacle") || other.gameObject.CompareTag("Ground"))
        {
             FindObjectOfType<Gamemanger>().GameOver();
             
             
           
        }
        else if (other.gameObject.CompareTag("score"))
        {
            FindObjectOfType<Gamemanger>().IncreaseScore();
            
        }

    }
}
