using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 6, false);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Keys"))
        {
            Destroy(collision.gameObject);
        }



    }








}
