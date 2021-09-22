using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypickup : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    bool isopened = false;



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isopened == false)
        {
            isopened = true;
            door.transform.position += new Vector3(0, 4, 0);
            Destroy(gameObject);
        }
    }
}




