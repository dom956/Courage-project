using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textactive : MonoBehaviour
{
    public GameObject text;



    public void OnTriggerEnter2D(Collider2D collsion)
    {
        if (text.activeInHierarchy)
        {
            text.SetActive(true);
        }
    }
}
