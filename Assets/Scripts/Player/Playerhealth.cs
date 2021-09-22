using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    Image healthmeter;
    float maxHealth = 10f;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        healthmeter = GetComponent<Image> ();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthmeter.fillAmount = health / maxHealth;
    }
}
