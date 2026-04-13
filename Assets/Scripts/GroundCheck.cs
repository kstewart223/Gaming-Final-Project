using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isOnGround;
        
    
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            isOnGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            isOnGround = false;
        }
    }

}
