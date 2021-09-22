using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;


    private void Start()
    {
        isFull = new bool[slots.Length];
        for (int i = 0; i < isFull.Length; i++)
        {
            isFull[i] = false;
        }
    }
}
