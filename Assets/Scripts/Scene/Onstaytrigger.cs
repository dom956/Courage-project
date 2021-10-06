using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onstaytrigger : MonoBehaviour
{


    [SerializeField]
    GameObject platform;
    bool istriggerd = false;
    bool nottriggered = false;

    

    private void OnTriggerStay2D(Collider2D other)
    {
        if (istriggerd == false)
        {
            istriggerd = true;
            platform.transform.position += new Vector3(0, -4, 0);


            




        }

        else if(nottriggered == false)
        {
            nottriggered = true;
            platform.transform.position += new Vector3(0, 0, 0);
        }







    }

}
