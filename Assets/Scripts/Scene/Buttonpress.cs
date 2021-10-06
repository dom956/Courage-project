using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonpress : MonoBehaviour
{
    [SerializeField]
    GameObject floor;
    bool istriggerd = false;
    bool nottriggered = false;



    private void OnTriggerStay2D(Collider2D other)
    {
        if (istriggerd == false)
        {
            istriggerd = true;
            floor.transform.position += new Vector3(3, 0, 0);







        }

        else if (nottriggered == false)
        {
            nottriggered = true;
            floor.transform.position += new Vector3(0, 0, 0);
        }







    }
}
