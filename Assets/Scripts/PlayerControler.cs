using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserScript : MonoBehaviour
{
    public float speed , jump, Move;
    public Rigidbody2D rb;
    public bool isGrounded, touchOpenNextDoor, touchPreviousDoor, isFacingRight;
    public Animator animator;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void FilpSprite()
    {
        if(isFacingRight && Move < 0f || !isFacingRight && Move > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);

        FilpSprite();
        if (Input.GetButtonDown("Jump") && isGrounded == false)
        {
            Debug.Log(isGrounded);
           rb.AddForce(new Vector2(0, jump));
        }
        if(touchOpenNextDoor == true)
        {
            SceneController.instance.NextLevel();
            
        }
        if (touchPreviousDoor == true)
        {
            SceneController.instance.PreviousLevel();

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }

            
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
        }
        if (other.gameObject.CompareTag("CloosedDoor"))
        {
            Debug.Log("test");
        }
        if (other.gameObject.CompareTag("OpenDoor"))
        {
            touchOpenNextDoor = true;
        }
        if (other.gameObject.CompareTag("PreviousDoor"))
        {
            touchPreviousDoor = true;
        }
        if (other.gameObject.CompareTag("CloosedDoor"))
        {
            Debug.Log("test");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
            animator.SetBool("isJumping", !isGrounded);
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