using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool onGround;
    private Rigidbody rig;
    public float jumpCutMultiplier = 0.5f;
    public GroundCheck trigger;
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if(Input.GetButtonDown("Jump") && trigger.isOnGround)
        {
            Jump();
        }

        if (Input.GetButtonUp("Jump") && rig.velocity.y > 0)
        {
            Release();
        }
    }

    void Jump()
    {
        rig.velocity = new Vector2(0, jumpForce);
    }

    void Release()
    {
        rig.velocity = new Vector2(0, rig.velocity.y * jumpCutMultiplier);
    }
}
