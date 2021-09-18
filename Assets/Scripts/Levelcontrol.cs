using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcontrol : MonoBehaviour
{
    public bool key = false;
    




    public void Keypickup()
    {
        key = true;
        Destroy(GameObject.Find("Keys"));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.GetComponent<Keypickup>() != null && other.GetComponent<Keypickup>())
        {
            SceneManager.LoadScene(1);


            
        }
    }




}
