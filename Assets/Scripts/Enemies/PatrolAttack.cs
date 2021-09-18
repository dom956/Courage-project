using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAttack : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public Transform groundDetection;

    public Transform target;
    bool isChased;
    bool notChased;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);

        if(groundInfo.collider == false)
        {

           

            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

           
        }

        
        if (isChased == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            isChased = true;
        }

        if (notChased == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            notChased = true;
        }







    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }


}
