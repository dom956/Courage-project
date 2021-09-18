using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerzone : MonoBehaviour
{
    public bool isInBox;
    private Transform Player;
    
    void Update()
    {
       
        



    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInBox = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInBox = false;
        }
        











    }

    


}
