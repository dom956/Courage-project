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

    public bool hasRedItem;
    private bool canUseRedItem;
    public bool usingRedItem;
    public SpriteRenderer mark;


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
                if (slots[0] == null) return;
                slots[0].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;
                
                break;
            case KeyCode.Alpha2:
                if (slots[1] == null) return;
                slots[1].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;
                
                break;
            case KeyCode.Alpha3:
                if (slots[2] == null) return;
                slots[2].GetComponentInChildren<Button>()?.onClick.Invoke();
                keyCode = 0;

                break;
        }

        //checking if user pressed 1 key
        if (Input.GetKeyDown(KeyCode.Alpha1) && hasRedItem && canUseRedItem)
        {
            StartCoroutine(RedItem());
        }
    }

    private void Start()
    {
        hasRedItem = false;
        canUseRedItem = true;
        usingRedItem = false;

        isFull = new bool[slots.Length];
        for (int i = 0; i < isFull.Length; i++)
        {
            isFull[i] = false;
        }
        
    }

    private IEnumerator RedItem()
    {
        canUseRedItem = false;
        usingRedItem = true;
        mark.color = Color.red;
        mark.enabled = true;
        yield return new WaitForSeconds(3f);
        usingRedItem = false;
        canUseRedItem = true;
        mark.enabled = false;
    }
}
