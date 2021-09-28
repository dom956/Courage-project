using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{

    public bool isGrounded = false;
    Movement playerscript;
    public GameObject pl;
  
    

    void Start()
    {
        playerscript = pl.GetComponent<Movement>();
    }

    void Update()
    {
        Jump();
    }

    
   



    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}