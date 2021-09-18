using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("Keys").GetComponent<Levelcontrol>().key = true;

        }
    }




}
