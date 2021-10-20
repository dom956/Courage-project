using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorMovement : MonoBehaviour
{
    //public float upLimit = 2.5f;
    //public float downLimit = 1.0f;
    public float[] floors;
    public float speed = 2.0f;
    private int direction = 1;
    private float destination;
    Vector2 Movement;

    public GameObject elevatorUI;
    private bool canMove;
    private GameObject player;
    private bool onElevator;
    public int distanceToTrigger;
    public GameObject elevatorButton;

    // Start is called before the first frame update
    void Start()
    {
        destination = floors[0];
        canMove = false;
        onElevator = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove && transform.position.y != destination)
        {
            if (transform.position.y > destination)
            {
                direction = -1;
            }
            else if (transform.position.y < destination)
            {
                direction = 1;
            }
            Movement = Vector2.up * direction * speed * Time.deltaTime;
            transform.Translate(Movement);
        }

        //calling elevator
        if (Input.GetKey(KeyCode.E) && Mathf.Abs(elevatorButton.transform.position.x - player.transform.position.x) < distanceToTrigger && !onElevator)
        {
            destination = floors[0];

            //for specific floors
            /*for (int i=0; i<floors.Length; i++)
            {
                if (Mathf.Abs(Mathf.RoundToInt(player.transform.position.y) - floors[i]) <= 3)
                {
                    destination = floors[i];
                    break;
                }
            }*/
            canMove = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onElevator = true;
            elevatorUI.GetComponent<Canvas>().enabled = true;
            elevatorUI.GetComponentInChildren<Button>().Select();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onElevator = false;
            elevatorUI.GetComponent<Canvas>().enabled = false;
        }
    }

    public void goToFloor(int floorNum)
    {
        destination = floors[floorNum-1];
        canMove = true;
    }

    public void closeElevatorUI()
    {
        elevatorUI.GetComponent<Canvas>().enabled = false;
    }
}
