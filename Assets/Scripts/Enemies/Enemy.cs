using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    float Range;
    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, Player.position);
        if(distToPlayer < Range)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }

        void ChasePlayer()
        {
            if(transform.position.x < Player.position.x)
            {
                rb2d.velocity = new Vector2(moveSpeed, 0);
                transform.localScale = new Vector2(1, 1);
            }
            else
            {
                rb2d.velocity = new Vector2(-moveSpeed, 0);
                transform.localScale = new Vector2(-1, 1);
            }
        }

        void StopChasingPlayer()
        {
            rb2d.velocity = new Vector2(0, 0);
        }

        
    }
    
}
