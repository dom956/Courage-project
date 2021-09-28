using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Green : MonoBehaviour
{
    public float updatedHealth;
    public float maxHealth;
    public float pointIncrease = 1f;
    
    




    // Start is called before the first frame update
    void Start()
    {
        updatedHealth = 10;
        maxHealth = 10;
        

        


    }

    // Update is called once per frame
    void Update()
    {

        updatedHealth += pointIncrease * Time.deltaTime;
        if (updatedHealth > maxHealth)
        {
            pointIncrease += 1;
            updatedHealth = maxHealth;
            
        }
        if (updatedHealth < 0)
        {
            updatedHealth = 0;
        }

       


    }

}
