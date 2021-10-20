using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatform : MonoBehaviour
{
    public BoxCollider2D boxcol;
    public BoxCollider2D boxcolTrigger;
    private bool hasItem;
    private float tempMoveSpeed;
    private float tempGravity;

    // Start is called before the first frame update
    void Start()
    {
        hasItem = false;
        tempMoveSpeed = 0f;
        tempGravity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //checking if player has red item
            GameObject player = other.gameObject;
            Playerinventory inventory = player.GetComponent<Playerinventory>();
            if (inventory.hasRedItem && inventory.usingRedItem)
            {
                hasItem = true;

                //disabling the box collider to allow player to pass through
                boxcol.enabled = false;

                //reducing player's movement speed by half
                tempMoveSpeed = player.GetComponent<Movement>().moveSpeed;
                player.GetComponent<Movement>().moveSpeed = tempMoveSpeed / 2;

                //reducing player's gravity by half
                tempGravity = player.GetComponent<Rigidbody2D>().gravityScale;
                player.GetComponent<Rigidbody2D>().gravityScale = tempGravity / 2;
            }
            else
            {
                //refreshing the trigger box collider
                boxcolTrigger.enabled = false;
                boxcolTrigger.enabled = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //resetting everything that was changed
        if (other.CompareTag("Player") && hasItem)
        {
            boxcol.enabled = true;
            other.gameObject.GetComponent<Movement>().moveSpeed = tempMoveSpeed;
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = tempGravity;
        }
    }
}
