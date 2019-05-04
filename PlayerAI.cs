using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //taking the componenet directly as PlayerAI is on Player Itself
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Obstacle")
        {
            if (transform.position.x > 1)
                transform.position = transform.position - new Vector3(5f, 0f, 0f);
            else if (transform.position.x < 1)
                transform.position = transform.position + new Vector3(5f, 0f, 0f);
        } // this part shows actuall logic of collion avoidance...I have manupulated box collider of the player
          // and Have set it to trigger, hence when obstacle triggers the collider it get transforms to left 
           // or right according per the player position towards the boundaries...  
    }
}
