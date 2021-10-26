using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropend : MonoBehaviour
{
    public GameObject[] keys;
    private int numKeys;
    private bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        numKeys = 0;
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen)
        {
            if (numKeys == keys.Length)
            {
                transform.position += new Vector3(0, 4, 0);
                isOpen = true;
            }
        }
    }

    public void pickedKey()
    {
        numKeys++;
    }
}
