using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhit : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collision)
    {
        Playerhealth.health -= 1f;
        
    }


}
