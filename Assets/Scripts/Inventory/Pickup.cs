using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : MonoBehaviour
{
    private Playerinventory inventory;

    public GameObject item;

    private void Start()
    {
        inventory = FindObjectOfType<Playerinventory>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    GameObject newItem = Instantiate(item, Vector3.zero, Quaternion.identity);
                    newItem.transform.SetParent(inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
