using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserScript : MonoBehaviour
{
    public float speed = 8f, jump = 350, Move, sprint;
    public Rigidbody2D rb;
    public bool isJumping, touchOpenNextDoor, touchPreviousDoor;

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false){
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
<<<<<<< HEAD
        if(touchOpenNextDoor == true)
        {
            SceneController.instance.NextLevel();
            
        }
        if (touchPreviousDoor == true)
        {
            SceneController.instance.PreviousLevel();

        }

=======

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }

        // if (Input.GetKey(KeyCode.LeftShift)){
        //     speed = speed * 1.5f;
        // }
            
>>>>>>> 14c1f7e (sprint OK)
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
        if (other.gameObject.CompareTag("OpenDoor"))
        {
            touchOpenNextDoor = true;
        }
        if (other.gameObject.CompareTag("PreviousDoor"))
        {
            touchPreviousDoor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
        if (other.gameObject.CompareTag("OpenDoor"))
        {
            touchOpenNextDoor = false;
        }
        if (other.gameObject.CompareTag("PreviousDoor"))
        {
            touchPreviousDoor = false;
        }
        

    }
   
}