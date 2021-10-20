using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilityactive : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        keypressed(); 
    }


    void pickedability()
    {
        GetComponent<Red>();
         
    }

    void keypressed()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Physics2D.IgnoreLayerCollision(3, 7);
            
        }
        else
        {
            Physics2D.IgnoreLayerCollision(0, 0);
            

            
        }
    }



}
