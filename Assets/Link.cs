using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.OpenURL("https://answers.unity.com/questions/35628/how-do-i-put-a-link-to-a-website-when-i-click-with.html");
        }  
    }





}
