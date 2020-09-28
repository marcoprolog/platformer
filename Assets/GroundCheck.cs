using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // set that the player can jump
        if (collision.gameObject.CompareTag("Platform"))
            pm.onGround = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // set that the player can not jump
        if (collision.gameObject.CompareTag("Platform"))
            pm.onGround = false;
    }
}
