using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signpostd : MonoBehaviour
{
    public GameObject textBoard;
    
    

    private void Start()
    {
        textBoard.SetActive(false);
        
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            textBoard.SetActive(true);
            
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textBoard.SetActive(false);
        }
    }
}
