using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupscriptd : MonoBehaviour
{
    private Playerinventory inventory;

    public GameObject image;

    private void Start()
    {
        inventory = FindObjectOfType<Playerinventory>();
    }




    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    GameObject newItem = Instantiate(image, Vector3.zero, Quaternion.identity);
                    newItem.transform.SetParent(inventory.slots[i].transform, false);


                    if (image.name == "red image")
                    {
                        inventory.hasRedItem = true;
                    }
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
