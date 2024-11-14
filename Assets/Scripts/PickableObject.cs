using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    private bool isInRange;
    public Animator animator;


    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInRange){
            TakeItem();
        }

    }

    void TakeItem(){
        animator.SetTrigger("PickUp");
    }
}

