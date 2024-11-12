using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position,-Vector2.up);

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector2(5, rb.velocity.y);
        }
        if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
             if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x, 5),
            raycast;
        }
        

        // if(Input.GetKey(KeyCode.Right)){
        //     lb.velocity = new Vector2(1, lb.velocity.y);
        // }
        // if(Input.GetKey(KeyCode.Q)){
        //     lb.velocity = new Vector2(1, lb.velocity.y);
        // }
    }
}
