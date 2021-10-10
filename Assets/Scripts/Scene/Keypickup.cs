using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypickup : MonoBehaviour
{
    [SerializeField]
    GameObject obstacle;
    bool isopened = false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isopened == false)
        {
            isopened = true;
            obstacle.transform.position += new Vector3(0, 4, 0);
            Destroy(gameObject);
        }
    }
}




