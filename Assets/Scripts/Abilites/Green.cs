using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Green : MonoBehaviour
{
    public float updatedHealth;
    public float maxHealth;
    public float pointIncrease = 1f;
    public Image healthmeter;




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
            updatedHealth = 10;
        }
        if (updatedHealth < 0)
        {
            updatedHealth = 0;
        }

        Playerhealth.health += pointIncrease;
        Playerhealth.health = updatedHealth;



    }

}
