using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorinventory : MonoBehaviour
{
    public GameObject[] colors;
    
    



    private void Start()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log("Color" + "Name");
        }
    }




}
