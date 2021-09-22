using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerinventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    Event e;
    KeyCode keyCode;


    private void OnGUI()
    {
        e = Event.current;
        if (e.isKey)
        {
            keyCode = e.keyCode;
        }
    }
    private void Update()
    {

        switch (keyCode)
        {
            case KeyCode.Alpha1:

                slots[0].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;
                break;
            case KeyCode.Alpha2:
                slots[1].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;
                break;
            case KeyCode.Alpha3:
                slots[2].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;
                break;
        }
    }

    private void Start()
    {
        isFull = new bool[slots.Length];
        for (int i = 0; i < isFull.Length; i++)
        {
            isFull[i] = false;
        }
    }
}
