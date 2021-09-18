using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilitesscript : MonoBehaviour
{

    
    public enum ColorsChoice
    {
        green,
        red,
        blue,
        yellow,
        purple,
        orange,

        
    }
    public ColorsChoice theColor;
    public bool isPrimary;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isPrimary = true;
        }
        switch (theColor)
        {
            case ColorsChoice.green:
                isPrimary = true;
                break;

            case ColorsChoice.red:
                isPrimary = true;
                break;

            case ColorsChoice.blue:
                isPrimary = true;
                break;

            case ColorsChoice.yellow:
                isPrimary = true;
                break;

            case ColorsChoice.purple:
                isPrimary = true;
                break;

            case ColorsChoice.orange:
                isPrimary = true;
                break;








        }






    }




}
